using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MIC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC.Equipos
{
    public partial class frmDevolucionEquipo : DevExpress.XtraEditors.XtraForm
    {
       
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;
        SqlTransaction transaction = null;
        public frmDevolucionEquipo(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
        }
        int codUser;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmFindUsers frm = new frmFindUsers();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                txtUserName.Text = frm.nombre;
                codUser = frm.id_user;
                CargarItemsPorUsuario();


            }
        }
        private void CargarItemsPorUsuario()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_get_items_by_user", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_user", codUser);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.items.Clear();
                adapter.Fill(dsItems1.items);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboMotivo.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Motivo");
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Usuario");
                return;
            }

            if (MessageBox.Show("Desea finalizar la asignacion de estos equipos?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                foreach (dsItems.itemsRow row in dsItems1.items.Rows)
                {
                    if (row.seleccionado)
                    {
                        try { 
                        
                            string Query = @"sp_update_mic_asignaciones_item";
                            SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                            cn.Open();
                            SqlCommand cmd = new SqlCommand(Query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_item", row.id);
                            cmd.Parameters.AddWithValue("@id_user", codUser);
                            cmd.Parameters.AddWithValue("@motivo", comboMotivo.Text);
                            cmd.ExecuteNonQuery();
                            try
                            {

                                SqlCommand command = new SqlCommand("sp_setUpdateItems_byState", cn);
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@id", row.id);
                                command.Parameters.AddWithValue("@id_estado", 3);
                                command.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                CajaDialogo.Error("Error: " + ex.Message);

                            }
                            
                        }
                        catch(Exception ex)
                        {
                            CajaDialogo.Error(ex.Message);
                        }


                        /*SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_update_mic_asignaciones_item";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_item", row.id);
                        cmd.Parameters.AddWithValue("@id_user", codUser);
                        cmd.Parameters.AddWithValue("@motivo", comboMotivo.EditValue);
                        //cmd.Parameters.AddWithValue("@id", );
                        try
                        {


                            SqlCommand command = new SqlCommand("sp_setUpdateItems_byState", conn);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@id", row.id);
                            command.Parameters.AddWithValue("@id_estado", 3);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error("Error: " + ex.Message);

                        }

                        conn.Close();*/
                    }
                    
                }
                CajaDialogo.InformationAuto();
                this.DialogResult = DialogResult.OK;
                this.Close();
                MIC.Reportes.rptDevolucionEquipo rpt = new Reportes.rptDevolucionEquipo(codUser);
                rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                ReportPrintTool printReport = new ReportPrintTool(rpt);
                printReport.ShowPreview();

            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}