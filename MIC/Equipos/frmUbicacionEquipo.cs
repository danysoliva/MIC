using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIC.Clases;
using System.Data.SqlClient;

namespace MIC.Equipos
{
    public partial class frmUbicacionEquipo : DevExpress.XtraEditors.XtraForm
    {

        int id_item;
        int id_ubicacion; int id_inserted;
        DataTable dt;
        DataOperations dp = new DataOperations();
        public frmUbicacionEquipo(string pEquipo, string pCodigo, int pId_Item)
        {
            InitializeComponent();
            txtNombre.Text = pEquipo;
            txtItemCode.Text = pCodigo;
            id_item = pId_Item;
            CargarUbicacionByItem();
            
        }

        

        private void CargarUbicacionByItem()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_locations_by_item", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_item", id_item);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.ubicacionEquipo.Clear();
                adapter.Fill(dsItems1.ubicacionEquipo);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            if (grdv_data.DataRowCount >= 1)
            {
                CajaDialogo.Error("No puede agregar mas de una ubicacion a un equipo");
            }
            else
            {
                frmSelectUbicacion frm = new frmSelectUbicacion();
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    dsItems.ubicacionEquipoRow row1 = dsItems1.ubicacionEquipo.NewubicacionEquipoRow();

                    var grid = (GridView)gridControlUbicacionxUser.FocusedView;

                    row1.idUbicacion = frm.idUbicacion;
                    row1.ubicacionEspecifica = frm.UbicacionEspecifica;
                    row1.ubicacionGeneral = frm.UbicacionGeneral;
                    row1.idEquipo = id_item;
                    

                    //if (frm.AtributoActual.Discontinued)
                    //    row1.IsDiscontinued = "Si";
                    //else
                    //    row1.IsDiscontinued = "No";

                    dsItems1.ubicacionEquipo.AddubicacionEquipoRow(row1);
                    dsItems1.AcceptChanges();

                }
            }
           
        }
                    



    //    frmSelectUbicacion frm = new frmSelectUbicacion();
    //if(frm.ShowDialog() == DialogResult.OK)
    //{

    //    dsItems.ubicacionEquipoRow row1 = dsItems1.ubicacionEquipo.NewubicacionEquipoRow();

    //    var grid = (GridView)gridControlUbicacionxUser.FocusedView;

    //    row1.idUbicacion = frm.idUbicacion;
    //    row1.ubicacionEspecifica = frm.UbicacionEspecifica;
    //    row1.ubicacionGeneral = frm.UbicacionGeneral;
    //    row1.idEquipo = id_item;

    //    //if (frm.AtributoActual.Discontinued)
    //    //    row1.IsDiscontinued = "Si";
    //    //else
    //    //    row1.IsDiscontinued = "No";

    //    dsItems1.ubicacionEquipo.AddubicacionEquipoRow(row1);
    //    dsItems1.AcceptChanges();

    //}


        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)gridControlUbicacionxUser.FocusedView;
                var row = (dsItems.ubicacionEquipoRow)gridView.GetFocusedDataRow();
                int id;
                id = row.idUbicacion;
                foreach (dsItems.ubicacionEquipoRow item in dsItems1.ubicacionEquipo.Rows)
                {
                    if (id == item.idUbicacion)
                    {
                        item.Delete();
                        item.AcceptChanges();
                        break;
                    }

                }
            }
            catch (Exception)
            {


            }
        }

        private void ValidarExistencia(int pId_Ubicacion)
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_check_ubicacion_by_item", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@id_item", id_item);
            cmm.Parameters.AddWithValue("@id_ubicacion", pId_Ubicacion);
            string inserted = cmm.ExecuteScalar().ToString();
            id_inserted = Convert.ToInt32(inserted);
            con.Close();


        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            //SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
            foreach (dsItems.ubicacionEquipoRow row1 in dsItems1.ubicacionEquipo.Rows)
            {
                ValidarExistencia(row1.idUbicacion);
                switch (id_inserted)
                {
                    case 1:
                        CajaDialogo.Information("El equipo ya está en esta ubicacion");
                        break;
                    default:
                        DialogResult r = CajaDialogo.Pregunta("Esta seguro de registrar el equipo en: " + row1.ubicacionEspecifica + "?");
                        if (r != DialogResult.Yes)
                            return;

                        string Query = @"sp_setInsertNewMic_UbicacionEquipo";
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                        try
                        {

                            cn.Open();

                            SqlCommand cmd = new SqlCommand(Query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_item", id_item);
                            cmd.Parameters.AddWithValue("@id_Ubicacion", row1.idUbicacion);
                            cmd.Parameters.AddWithValue("@enable", 1);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();


                            //APMSV2.IT.Reportes.rptEntregaEquipo rpt = new Reportes.rptEntregaEquipo(id_Equipo, row.user, row.id);
                            //rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                            //ReportPrintTool printReport = new ReportPrintTool(rpt);
                            //printReport.ShowPreview();



                            CajaDialogo.Information("Equipo asignado Satisfactoriamente.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                            
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            CajaDialogo.Error(ex.Message);
                        }
                        break;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}