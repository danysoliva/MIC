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
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        int id_item;
        int id_inserted;
        int id_TipoEquipo;
        DataOperations dp = new DataOperations();
        public frmUsers(string pEquipo, string pCodigo, int pId_Item, int PidTipoEquipo)
        {
            
            InitializeComponent();
            txtNombre.Text = pEquipo;
            txtItemCode.Text = pCodigo;
            id_item = pId_Item;
            id_TipoEquipo = PidTipoEquipo;
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

        private void ValidarExistencia(int pId_User)
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_check_users_by_item", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@id_item", id_item );
            cmm.Parameters.AddWithValue("@id_user", pId_User);
            string inserted = cmm.ExecuteScalar().ToString();
            id_inserted = Convert.ToInt32(inserted);
            con.Close();


        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            //var gridView = (GridView)gridControlUsers.FocusedView;
            //var row = (dsItems.usersRow)gridView.GetFocusedDataRow();

            //DataOperations dp = new DataOperations();

            frmFindUsers frm = new frmFindUsers();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                //dsItems.usersRow row = dsItems1.users.NewusersRow();

                var gridView = (GridView)gridControlUsers.FocusedView;
                bool exite = false;
                foreach (dsItems.usersRow row in dsItems1.users.Rows)
                {
                    if (row.id == frm.id_user)
                    {
                        exite = true;
                    }
                }
                if (!exite)
                {

                    DataRow dr = dsItems1.users.NewRow();
                    dr[0] = frm.id_user;
                    dr[1] = frm.nombre;
                    dsItems1.users.Rows.Add(dr);
                    dsItems1.users.AcceptChanges();
                    //row.id = frm.id_user;
                    //row.user = frm.nombre;
                }
                

                //dsItems1.users.AddusersRow(row);
                //dsItems1.AcceptChanges();

                //if (row.id == row.id)
                //{

                //    //row.descripcion_mostrar = frm.ItemActual.descripcion_mostrar_tables;



                //    ////if (frm.AtributoActual.Discontinued)
                //    ////    row.IsDiscontinued = "Si";
                //    ////else
                //    ////    row.IsDiscontinued = "No";

                //    //dsItems1.AcceptChanges();
                //    //CargarItems(true);

                //}
            }
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //bool Guardar = false;

            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            //SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
            foreach (dsItems.usersRow row1 in dsItems1.users.Rows)
            {
                ValidarExistencia(row1.id);

                switch (id_inserted)
                {
                    case 1:
                        //CajaDialogo.Information("El usuario " + row1.user + " ya tiene asignado este equipo");
                        break;
                    default:
                    DialogResult r = CajaDialogo.Pregunta("Esta seguro de asignar el equipo a: "+ row1.user + "?");
                                if (r != DialogResult.Yes)
                                    return;

                                string Query = @"sp_setInsertNewUserItem";
                                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                                try
                                {
                
                                    cn.Open();
                                    
                                    SqlCommand cmd = new SqlCommand(Query, cn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_item", id_item);
                                    cmd.Parameters.AddWithValue("@id_it_user", 1137);
                                    cmd.Parameters.AddWithValue("@id_user", row1.id);
                                    cmd.ExecuteNonQuery();
                                    cmd.Parameters.Clear();
                                                
                                     
                                        //APMSV2.IT.Reportes.rptEntregaEquipo rpt = new Reportes.rptEntregaEquipo(id_Equipo, row.user, row.id);
                                        //rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        //ReportPrintTool printReport = new ReportPrintTool(rpt);
                                        //printReport.ShowPreview();
                                    

                                   
                                    CajaDialogo.Information("Equipo asignado Satisfactoriamente.");
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                    if (id_TipoEquipo==13)
                                     {
                                     MIC.Reportes.rptEntregaCelulares rpt = new Reportes.rptEntregaCelulares(id_item);
                                     rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                     ReportPrintTool printReport = new ReportPrintTool(rpt);
                                     printReport.ShowPreview();

                                     }
                                    else
                                    {
                                        MIC.Reportes.rptEntregaEquipos rpt = new Reportes.rptEntregaEquipos(id_item, row1.user, row1.id);
                                        rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                                        ReportPrintTool printReport = new ReportPrintTool(rpt);
                                        printReport.ShowPreview();

                                    }
                                    
                                    
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    CajaDialogo.Error(ex.Message);
                                }

                                try
                                {


                                    SqlCommand command = new SqlCommand("sp_setUpdateItems_byState", cn);
                                    command.CommandType = CommandType.StoredProcedure;

                                    command.Parameters.AddWithValue("@id", id_item);
                                    command.Parameters.AddWithValue("@id_estado", 4);
                                    command.ExecuteNonQuery();

                                }
                                catch (Exception ex)
                                {
                                    CajaDialogo.Error("Error: " + ex.Message);

                                }
                        break;
                }
            }

            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}