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
using DevExpress.XtraGrid.Views.Grid;
using MIC.Clases;
namespace MIC.Equipos
{
    public partial class frmHomeAtributos1 : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        public frmHomeAtributos1()
        {
            InitializeComponent();
        }

        public frmHomeAtributos1(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            tggVerTodos.IsOn = true;
            CargarAtributos(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tggVerTodos_Toggled(object sender, EventArgs e)
        {
            CargarAtributos(tggVerTodos.IsOn);
        }

        private void frmHomeAtributos1_Load(object sender, EventArgs e)
        {

        }
        private void CargarAtributos(bool pMostrarInhabilitados)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_all_mic_atributos", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pEnable", pMostrarInhabilitados);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsAtributos1.HOMEAtributos.Clear();
                adapter.Fill(dsAtributos1.HOMEAtributos);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void cmdNuevoAtributo_Click(object sender, EventArgs e)
        {
            frmCRUDAtributos frm = new frmCRUDAtributos(frmCRUDAtributos.ComportamientoCRUD.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsAtributos.HOMEAtributosRow row1 = dsAtributos1.HOMEAtributos.NewHOMEAtributosRow();


                row1.id = frm.AtributoActual.id;
                row1.descripcion = frm.AtributoActual.descripcion;
                row1.enable = frm.AtributoActual.enable;
                row1.imprimible = frm.AtributoActual.imprimible;
                row1.TipoDato = frm.AtributoActual.descripcion_tipodato;
                row1.id_tipo_dato = frm.AtributoActual.tipo_dato;
                row1.TipoDato = frm.gleAtributos.Text;



                //if (frm.AtributoActual.Discontinued)
                //    row1.IsDiscontinued = "Si";
                //else
                //    row1.IsDiscontinued = "No";

                dsAtributos1.HOMEAtributos.AddHOMEAtributosRow(row1);
                dsAtributos1.AcceptChanges();
            }
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            var gridView = (GridView)gridControlHomeAtributos.FocusedView;
            var row = (dsAtributos.HOMEAtributosRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();



            frmCRUDAtributos frm = new frmCRUDAtributos(frmCRUDAtributos.ComportamientoCRUD.Update, dp.ValidateNumberInt32(row.id));
            if (frm.ShowDialog() == DialogResult.OK)
            {

                if (row.id == row.id)
                {
                    row.descripcion = frm.AtributoActual.descripcion;
                    row.enable = frm.AtributoActual.enable;
                    row.imprimible = frm.AtributoActual.imprimible;
                    row.TipoDato = frm.AtributoActual.descripcion_tipodato;
                    row.id_tipo_dato = frm.AtributoActual.tipo_dato;
                    row.TipoDato = frm.gleAtributos.Text;

                    //if (frm.AtributoActual.Discontinued)
                    //    row.IsDiscontinued = "Si";
                    //else
                    //    row.IsDiscontinued = "No";

                    dsAtributos1.AcceptChanges();

                }
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}