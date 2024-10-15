using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDevolverEquipo : DevExpress.XtraEditors.XtraForm
    {

        public frmDevolverEquipo()
        {
            InitializeComponent();
        }
        int id_item;
        DataOperations dp = new DataOperations();
        public frmDevolverEquipo(string pEquipo, string pCodigo, int pId_Item)
        {

            InitializeComponent();
            txtNombre.Text = pEquipo;
            txtItemCode.Text = pCodigo;
            id_item = pId_Item;
            CargarUsersByItem();

        }
        private void CargarUsersByItem()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_users_by_item", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_item", id_item);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.users.Clear();
                adapter.Fill(dsItems1.users);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void cmdDevolver_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (string.IsNullOrEmpty(gleMotivo.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Motivo");
                return;
            }
            var gridView = (GridView)gridDevolverEquipos.FocusedView;
            var row = (dsItems.usersRow)gridView.GetFocusedDataRow();

            if (MessageBox.Show("Desea finalizar la asignacion de este equipo?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string Query = @"sp_update_mic_asignaciones_item";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_item", id_item);
                    cmd.Parameters.AddWithValue("@id_user", row.id);
                    cmd.Parameters.AddWithValue("@motivo", gleMotivo.Text);
                    try
                    {


                        SqlCommand command = new SqlCommand("sp_setUpdateItems_byState", cn);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@id", id_item);
                        command.Parameters.AddWithValue("@id_estado", 3);
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error("Error: " + ex.Message);

                    }

                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)


                    {
                        if (MessageBox.Show("Operacion Exitosa, Desea salir del formulario?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            cn.Close();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            MIC.Reportes.rptDevolucionEquipo rpt = new Reportes.rptDevolucionEquipo(row.id);
                            rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            ReportPrintTool printReport = new ReportPrintTool(rpt);
                            printReport.ShowPreview();
                        }
                        else
                        {
                            cn.Close();
                            CargarUsersByItem();
                        }

                    }
                    cn.Close();


                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void cmdDevolver_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void cmdImprimirHoja_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridDevolverEquipos.FocusedView;
            var row = (dsItems.usersRow)gridView.GetFocusedDataRow();

            MIC.Reportes.rptEntregaEquipos rpt = new Reportes.rptEntregaEquipos(id_item, row.user, row.id);
            rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(rpt);
            printReport.ShowPreview();
        }

        private void frmDevolverEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}