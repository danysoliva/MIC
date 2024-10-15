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
    public partial class frmUbicaciones : DevExpress.XtraEditors.XtraForm
    {
        public frmUbicaciones(ComportamientoCRUD pComportamientoActual, int pItem)
        {
            InitializeComponent();
            CargarUbicaciones();
            this.ComportamientoActual = pComportamientoActual;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:

                    break;

                case ComportamientoCRUD.Update:
                    //if (ItemActual.RecuperarRegistro(pItemId))
                    //{

                    //    gleTipoEquipo.EditValue = ItemActual.id_tipo_equipo;
                    //    gleIdEstado.EditValue = ItemActual.id_estado;
                    //    txtItemCode.Text = ItemActual.items_code;
                    //    txtName.Text = ItemActual.nombre;
                    //    txtIdTipoEquipo.Text = ItemActual.id_tipo_equipo.ToString();
                    //    txtMarca.Text = ItemActual.marca;
                    //    txtComentario.Text = ItemActual.comentario;
                    //    tggEnable.IsOn = ItemActual.enable;
                    //    tggBitAsignable.IsOn = ItemActual.bit_asignable;
                    //    load_config_atributos_equipos();

                    //}
                    break;

            }
        }

        private void CargarUbicaciones()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_all_mic_ubicaciones", connection);
                command.CommandType = CommandType.StoredProcedure;
                dsItems1.ubicacionGeneral.Clear();
               
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                
                adapter.Fill(dsItems1.ubicacionGeneral);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        public enum ComportamientoCRUD
        {
            Insert = 1,
            Update = 2,

        }

        ComportamientoCRUD ComportamientoActual;

        private void frmUbicaciones_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmUbicacionesOP frm = new frmUbicacionesOP(frmUbicacionesOP.ComportamientoCRUD.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarUbicaciones();
                //dsItems.itemsRow row1 = dsItems1.items.NewitemsRow();


                



                ////if (frm.AtributoActual.Discontinued)
                ////    row1.IsDiscontinued = "Si";
                ////else
                ////    row1.IsDiscontinued = "No";

                //dsItems1.items.AdditemsRow(row1);
                //dsItems1.AcceptChanges();
                //CargarItems(true);
            }
        }

        private void btneditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsItems.ubicacionGeneralRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();



            frmUbicacionesOP frm = new frmUbicacionesOP(frmUbicacionesOP.ComportamientoCRUD.Update, dp.ValidateNumberInt32(row.id));
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (row.id == row.id)
                {

                    row.id = frm.idUbicacion;
                    row.descripcion = frm.descripcion;
                    row.enable = frm.enable;
                    


                    //if (frm.AtributoActual.Discontinued)
                    //    row.IsDiscontinued = "Si";
                    //else
                    //    row.IsDiscontinued = "No";

                    dsItems1.AcceptChanges();
                    

                }
            }
        }
    }
}