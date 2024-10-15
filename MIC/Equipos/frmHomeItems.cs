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
using MIC.Clases;

namespace MIC.Equipos
{
    public partial class frmHomeItems : Form
    {
        UserLogin UsuarioLogeado;
        public frmHomeItems()
        {
            InitializeComponent();
        }

        public frmHomeItems(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            tggVerTodos.IsOn = false;
            CargarItems(false);


        }



        private void frmHomeItems_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

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

                dsItems.items.Clear();
                adapter.Fill(dsItems.items);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void cmdNuevoItems_Click(object sender, EventArgs e)
        {
            //Para llamar a la ventana y agregar un nuevo items
            //El valor de parametro en id items lo mando como 0, esto porque se va a crear uno nuevo
            FrmCRUDItems frm = new FrmCRUDItems(FrmCRUDItems.ComportamientoCRUD.Insert, 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsItems.itemsRow row1 = dsItems.items.NewitemsRow();


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

                dsItems.items.AdditemsRow(row1);
                dsItems.AcceptChanges();
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tggVerTodos_Toggled(object sender, EventArgs e)
        {
            //Si activa ver todos en: On=Si
            //Mostraremos todos los productos, incluyendo los descontinuados.
            CargarItems(tggVerTodos.IsOn);
        }

        private void tggVerTodos_Toggled_1(object sender, EventArgs e)
        {
            //Si activa ver todos en: On=Si
            //Mostraremos todos los productos, incluyendo los descontinuados.
            CargarItems(tggVerTodos.IsOn);
        }
    }
}
