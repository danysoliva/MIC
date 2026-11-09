using DevExpress.XtraEditors;
using MIC.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MIC.Equipos
{
    public partial class frmListaDevolucionesHome : XtraForm
    {
        UserLogin UsuarioLogeado;

        public frmListaDevolucionesHome()
        {
            InitializeComponent();
            CargarDatos();
        }

        public frmListaDevolucionesHome(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringMIC))
                using (SqlCommand command = new SqlCommand(@"sp_get_lista_devoluciones_items", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    gridControl1.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmDevolucionEquipo frm = new frmDevolucionEquipo(UsuarioLogeado))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    CargarDatos();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
