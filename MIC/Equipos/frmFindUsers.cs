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
    public partial class frmFindUsers : DevExpress.XtraEditors.XtraForm
    {

        DataOperations dp = new DataOperations();
        public int id_user;
        public string nombre;
        public frmFindUsers()
        {
            InitializeComponent();
            load_data();
        }


        public frmFindUsers(int pId_user, string pNombre)
        {
            InitializeComponent();
            load_data();

        }
        public void load_data()
        {
            string Query = @"sp_load_user";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dsItems1.users.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsItems1.users);
                dv = new DataView(dsItems1.users);
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        private void cmdAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnagregar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsItems.usersRow)gridView.GetFocusedDataRow();
            id_user = row.id;
            nombre = row.user;
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
            
        }
        DataView dv;
        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = @"[user] like '%" + txtParametroBusqueda.Text + "%'";
            grd_data.DataSource = dv;
        }

        private void txtParametroBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (dv.Count == 1)
                {
                    var gridView = (GridView)grd_data.FocusedView;
                    var row = (dsItems.usersRow)gridView.GetDataRow(0);
                    id_user = row.id;
                    nombre = row.user;
                    cmdAplicar_Click(new object(), new EventArgs());
                }
                
            }
        }
    }
}