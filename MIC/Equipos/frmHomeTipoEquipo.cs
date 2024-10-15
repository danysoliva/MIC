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
    public partial class frmHomeTipoEquipo : DevExpress.XtraEditors.XtraForm
    {

        UserLogin UsuarioLogeado;
        public frmHomeTipoEquipo()
        {
            InitializeComponent();

        }

        public frmHomeTipoEquipo(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            CargarTipoEquipos();
        }

        private void frmHomeTipoEquipo_Load(object sender, EventArgs e)
        {

        }

        private void CargarTipoEquipos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_all_mic_tablesID", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsAtributos1.TablesID.Clear();
                adapter.Fill(dsAtributos1.TablesID);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void btnnuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmTipoEquipos frm = new frmTipoEquipos(this.UsuarioLogeado);
            //frm.Show();

            frmTipoEquipos frm = new frmTipoEquipos(frmTipoEquipos.ComportamientoCRUD.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsAtributos.TablesIDRow row1 = dsAtributos1.TablesID.NewTablesIDRow();

                var gridView2 = (GridView)gridControlTipoEquipo.FocusedView;
                

                row1.id = frm.TablesIDActual.id;
                row1.descripcion = frm.TablesIDActual.descripcion;
                row1.descripcion_mostrar = frm.TablesIDActual.descripcion_mostrar;
                row1.enable = frm.TablesIDActual.enable;
                row1.id_siguiente = frm.TablesIDActual.id_siguiente;
                row1.codigo = frm.TablesIDActual.codigo;




                //if (frm.AtributoActual.Discontinued)
                //    row1.IsDiscontinued = "Si";
                //else
                //    row1.IsDiscontinued = "No";
               
                dsAtributos1.TablesID.AddTablesIDRow(row1);
                dsAtributos1.AcceptChanges();
                CargarTipoEquipos();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlTipoEquipo.FocusedView;
            var row = (dsAtributos.TablesIDRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();



            frmTipoEquipos frm = new frmTipoEquipos(frmTipoEquipos.ComportamientoCRUD.Update, dp.ValidateNumberInt32(row.id));
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (row.id == row.id)
                {

                    row.id = frm.TablesIDActual.id;
                    row.descripcion = frm.TablesIDActual.descripcion;
                    row.enable = frm.TablesIDActual.enable;
                    row.descripcion_mostrar = frm.TablesIDActual.descripcion_mostrar;
                    row.id_siguiente = frm.TablesIDActual.id_siguiente;
                    row.codigo = frm.TablesIDActual.codigo;
                    

                    //if (frm.AtributoActual.Discontinued)
                    //    row.IsDiscontinued = "Si";
                    //else
                    //    row.IsDiscontinued = "No";

                    dsAtributos1.AcceptChanges();

                }
            }
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}