using DevExpress.XtraEditors;
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
using DevExpress.XtraGrid.Views.Grid;


namespace MIC.Equipos
{
    public partial class findAtributos : DevExpress.XtraEditors.XtraForm
    {
        public int id_selected;
        public string atributo;
        public int tipoDato;
        public findAtributos(int pId_tipo, UserLogin pUser )
        {
            InitializeComponent();
            load_data(pId_tipo);
            
        }
        DataTable dt;
        DataOperations dp = new DataOperations();
        UserLogin UsuarioLogeado;  //Constructor

        //public findAtributos(DataTable pdt)
        //{
        //    InitializeComponent();
        //    dt = pdt;
        //    CargarAtributos();

        //}

        //public findAtributos(UserLogin pUser)
        //{
        //    InitializeComponent();
        //    CargarAtributos();
        //    UsuarioLogeado = pUser;

        //}

        public void load_data(int pid_Tipo)
        {
            string Query = @"[dbo].[sp_it_load_config_atributos_noselected]";
            try
            {

                DataOperations dp = new DataOperations();

                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipo ", pid_Tipo);
                cmd.Parameters.AddWithValue("@bit ", 0);
                dsAtributos1.atributos.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsAtributos1.atributos);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }



        }

        //private void CargarAtributos()
        //{
        //    try
        //    {
        //        DataOperations dp = new DataOperations();
        //        SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
        //        connection.Open();

        //        SqlCommand command = new SqlCommand("dbo.sp_get_all_mic_atributos_list", connection);
        //        command.CommandType = CommandType.StoredProcedure;

        //        SqlDataAdapter adapter = new SqlDataAdapter(command);

        //        dsAtributos1.atributos.Clear();
        //        adapter.Fill(dsAtributos1.atributos);
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error("Error:" + ex.Message);
        //    }
        //}
        private void findAtributos_Load(object sender, EventArgs e)
        {

        }

        private void grd_data_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var gv = (GridView)grd_data.FocusedView;
                var row = (dsAtributos.atributosRow)gv.GetDataRow(gv.FocusedRowHandle);
                id_selected = row.id;
                atributo = row.descripcion;
                tipoDato = row.idtipoDato;
                this.DialogResult = DialogResult.OK;
                this.Close();
                //frmVerSeguimiento frm = new frmVerSeguimiento(row.id, UsuarioLogeado);

                //frm.ShowDialog();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void grd_data_Click_1(object sender, EventArgs e)
        {

        }
    }
}