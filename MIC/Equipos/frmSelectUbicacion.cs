using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmSelectUbicacion : DevExpress.XtraEditors.XtraForm
    {
        public string UbicacionEspecifica, UbicacionGeneral;
        public int idUbicacion;
        public frmSelectUbicacion()
        {
            InitializeComponent();
            load_ubicacion_general();

        }
        public int id_edificio;
        DataOperations dp = new DataOperations();

        public void load_ubicacion_general()
        {
            string Query = @"sp_get_all_mic_ubicaciones";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsItems1.ubicacionGeneral.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsItems1.ubicacionGeneral);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_ubicacion()
        {
            string Query = @"sp_it_load_ubicacion_from_id";
            try
            {
                
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_edificio", id_edificio);
                dsItems1.ubicacion.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsItems1.ubicacion);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void btnseleccionar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // try
            //{
            //    var gridView = (GridView)grd_equipo.FocusedView;
            //    var row = (dsItems.ubicacionRow)gridView.GetFocusedDataRow();
            //    id_edificio = row.id;
            //    load_ubicacion();
            //    this.navigationFrame1.SelectNextPage();

            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void grd_ubi_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void btnseleccionar_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_equipo.FocusedView;
                var row = (dsItems.ubicacionGeneralRow)gridView.GetFocusedDataRow();
                id_edificio = row.id;
                UbicacionGeneral = row.descripcion;
                load_ubicacion();
                navigationFrame1.SelectedPage = navigationPage2;

            }
            catch (Exception ex)
            {

            }
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void page1_Click(object sender, EventArgs e)
        {
            
        }

        private void page2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gridView = (GridView)grd_ubi.FocusedView;
                var row = (dsItems.ubicacionRow)gridView.GetFocusedDataRow();
                idUbicacion = row.id;
                UbicacionEspecifica = row.descripcion;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}