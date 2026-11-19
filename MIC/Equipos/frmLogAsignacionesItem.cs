using DevExpress.XtraEditors;
using MIC.Clases;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MIC.Equipos
{
    public partial class frmLogAsignacionesItem : XtraForm
    {
        int _idItem;

        public frmLogAsignacionesItem()
        {
            InitializeComponent();
        }

        public frmLogAsignacionesItem(int idItem, string codigo, string nombre)
        {
            InitializeComponent();
            _idItem = idItem;
            lblItem.Text = (codigo ?? string.Empty) + "  -  " + (nombre ?? string.Empty);
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection connection = new SqlConnection(dp.ConnectionStringMIC))
                using (SqlCommand command = new SqlCommand("sp_get_lista_devoluciones_items_by_item", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_item", _idItem);

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
