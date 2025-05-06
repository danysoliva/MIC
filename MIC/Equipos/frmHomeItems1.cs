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
using MIC.Equipos;
using MIC.Clases;
using DevExpress.XtraGrid.Views.Grid;

namespace MIC.Equipos
{
    public partial class frmFindAtributos : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmFindAtributos()
        {
            InitializeComponent();
            CargarItems(true);
        }

        public frmFindAtributos(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            tggVerTodos.IsOn = true;
            CargarItems(true);


        }

        private void CargarItems(bool pMostrarInhabilitados)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_all_mic_items", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pEnable", pMostrarInhabilitados);
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

        private void frmHomeItems1_Load(object sender, EventArgs e)
        {

        }

        private void cmdNuevoItems_Click(object sender, EventArgs e)
        {
            FrmCRUDItems frm = new FrmCRUDItems(FrmCRUDItems.ComportamientoCRUD.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsItems.itemsRow row1 = dsItems1.items.NewitemsRow();


                row1.id = frm.ItemActual.id;
                row1.items_code = frm.ItemActual.items_code;
                row1.nombre = frm.ItemActual.nombre;
                row1.id_tipo_equipo = frm.ItemActual.id_tipo_equipo;
                row1.marca = frm.ItemActual.marca;
                row1.comentario = frm.ItemActual.comentario;
                row1.bit_asignable = frm.ItemActual.bit_asignable;
                row1.created = frm.ItemActual.created;
                
                row1.descripcion_mostrar = frm.ItemActual.descripcion_mostrar_tables;
                row1.descripcion_mostrar = frm.gleIdEstado.Text;



                //if (frm.AtributoActual.Discontinued)
                //    row1.IsDiscontinued = "Si";
                //else
                //    row1.IsDiscontinued = "No";

                dsItems1.items.AdditemsRow(row1);
                dsItems1.AcceptChanges();
                CargarItems(true);
            }
        }

        private void tggVerTodos_Toggled(object sender, EventArgs e)
        {

            //if (tggVerTodos.IsOn)
            //{
            //    CargarItems(tggVerTodos.IsOn);
            //}
            //else
            //{
            //    CargarItems(false);
            //}
            CargarItems(tggVerTodos.IsOn);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmHomeTipoEquipo frm = new frmHomeTipoEquipo(this.UsuarioLogeado);
            frm.Show();
        }

        private void lblTituloVentana_Click(object sender, EventArgs e)
        {

        }

        private void cmdEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlHomeItems.FocusedView;
            var row = (dsItems.itemsRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();

            FrmCRUDItems frm = new FrmCRUDItems(FrmCRUDItems.ComportamientoCRUD.Update, dp.ValidateNumberInt32(row.id));
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (row.id == row.id)
                {
                    row.descripcion_mostrar = frm.ItemActual.descripcion_mostrar_tables;
                    row.nombre = frm.ItemActual.nombre;
                    row.marca = frm.ItemActual.marca;
                    row.enable = frm.ItemActual.enable;
                    row.comentario = frm.ItemActual.comentario;
                    row.estado = frm.ItemActual.estado;
                    row.created = frm.ItemActual.created;



                    //if (frm.AtributoActual.Discontinued)
                    //    row.IsDiscontinued = "Si";
                    //else
                    //    row.IsDiscontinued = "No";

                    dsItems1.AcceptChanges();
                    CargarItems(true);

                }
            }
        }


        private void cmdAddUser_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var gridView = (GridView)gridControlHomeItems.FocusedView;
            var row = (dsItems.itemsRow)gridView.GetFocusedDataRow();
            DataOperations dp = new DataOperations();


            switch (row.id_estado)
            {
                case 3:
                    if (row.bit_asignable == true )
                    {
                        frmUsers frm = new frmUsers(row.nombre, row.items_code, row.id, row.id_tipo_equipo);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            if (row.id == row.id)
                            {
                                CargarItems(true);
                          
                            }

                        }

                    }
                    
                    break;

                case 4:
                    if (row.multiusuario == true)
                    {
                        frmUsers frm = new frmUsers(row.nombre, row.items_code, row.id, row.id_tipo_equipo);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            if (row.id == row.id)
                            {
                                CargarItems(true);

                            }

                        }
                    }
                    else
                    {
                        CajaDialogo.Error("No se puede asignar a mas de un usuario");
                    }
                    break;
                default:
                    CajaDialogo.Error("No se puede asignar");
                    break;

            }

            
        }

        private void cmdDevolverEquipo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlHomeItems.FocusedView;
            var row = (dsItems.itemsRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();

            frmDevolverEquipo frm = new frmDevolverEquipo(row.nombre, row.items_code, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (row.id == row.id)
                {
                    CargarItems(true);
                    //row.descripcion_mostrar = frm.ItemActual.descripcion_mostrar_tables;



                    ////if (frm.AtributoActual.Discontinued)
                    ////    row.IsDiscontinued = "Si";
                    ////else
                    ////    row.IsDiscontinued = "No";

                    //dsItems1.AcceptChanges();
                    //CargarItems(true);

                }




                //var gridView = (GridView)grd_data.FocusedView;
                //var row = (dsIT.EquipoRow)gridView.GetFocusedDataRow();
                //frmAsignacion frm = new frmAsignacion(row.id, row.barcode, row.nombre, UsuarioLogeado);
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    load_data();
                //}//coment
            }
        }

        private void cmdAdjuntarArchivos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlHomeItems.FocusedView;
            var row = (dsItems.itemsRow)gridView.GetFocusedDataRow();

            frmAdjuntarArchivos frm = new frmAdjuntarArchivos(row.id, UsuarioLogeado );
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarItems(true);
                //    if (row.id == row.id)
                //    {
                //        //row.descripcion_mostrar = frm.ItemActual.descripcion_mostrar_tables;



                //        ////if (frm.AtributoActual.Discontinued)
                //        ////    row.IsDiscontinued = "Si";
                //        ////else
                //        ////    row.IsDiscontinued = "No";

                //        //dsItems1.AcceptChanges();
                //        //CargarItems(true);

                //    }




                //    //var gridView = (GridView)grd_data.FocusedView;
                //    //var row = (dsIT.EquipoRow)gridView.GetFocusedDataRow();
                //    //frmAsignacion frm = new frmAsignacion(row.id, row.barcode, row.nombre, UsuarioLogeado);
                //    //if (frm.ShowDialog() == DialogResult.OK)
                //    //{
                //    //    load_data();
                //    //}//comen
                //}
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmUbicaciones frm = new frmUbicaciones(frmUbicaciones.ComportamientoCRUD.Insert,0);
            frm.Show();
        }

        private void cmdUbicacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlHomeItems.FocusedView;
            var row = (dsItems.itemsRow)gridView.GetFocusedDataRow();

            frmUbicacionEquipo frm = new frmUbicacionEquipo(row.nombre, row.items_code, row.id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarItems(true);
                //    if (row.id == row.id)
                //    {
                //        //row.descripcion_mostrar = frm.ItemActual.descripcion_mostrar_tables;



                //        ////if (frm.AtributoActual.Discontinued)
                //        ////    row.IsDiscontinued = "Si";
                //        ////else
                //        ////    row.IsDiscontinued = "No";

                //        //dsItems1.AcceptChanges();
                //        //CargarItems(true);

                //    }




                //    //var gridView = (GridView)grd_data.FocusedView;
                //    //var row = (dsIT.EquipoRow)gridView.GetFocusedDataRow();
                //    //frmAsignacion frm = new frmAsignacion(row.id, row.barcode, row.nombre, UsuarioLogeado);
                //    //if (frm.ShowDialog() == DialogResult.OK)
                //    //{
                //    //    load_data();
                //    //}//comen
                //}
            }
        }

        private void cmdDiagnostico_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlHomeItems.FocusedView;
            var row = (dsItems.itemsRow)gridView.GetFocusedDataRow();
            //frmDiagnosticoEquipos frm = new frmDiagnosticoEquipos(frmDiagnosticoEquipos.ComportamientoCRUD.Nuevo, row.id,0, UsuarioLogeado);
            frmHomeDiagnosticos frm = new frmHomeDiagnosticos(UsuarioLogeado, row.id);
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmHomeAtributos1 frm = new frmHomeAtributos1(this.UsuarioLogeado);
            frm.Show();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            frmDevolucionEquipo frm = new frmDevolucionEquipo(this.UsuarioLogeado);
            frm.Show();
        }
    }
 }
