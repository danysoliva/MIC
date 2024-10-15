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




namespace MIC.Equipos
{
    public partial class frmTipoEquipos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_tipo;
        public enum ComportamientoCRUD
        {
            Insert = 1,
            Update = 2
        }

        public TipoEquipo TablesIDActual;
        UserLogin UsuarioLogeado;  //Constructor

        ComportamientoCRUD ComportamientoActual;
        //public frmTipoEquipos(UserLogin pUser)
        //{
        //    InitializeComponent();
        //    CargarAtributos();
        //    load_atributos_tipo_equipo();
        //    UsuarioLogeado = pUser;
        //}


        public void load_atributos_tipo_equipo()
        {
            string Query;
            switch (ComportamientoActual)
            {
                case  ComportamientoCRUD.Insert:
                    Query = @"sp_it_load_config_atributos";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tipo", 0);
                        cmd.Parameters.AddWithValue("@bit", 1);
                        dsAtributos1.findAtributos.Clear();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dsAtributos1.findAtributos);
                        cn.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                case ComportamientoCRUD.Update:
                    Query = @"sp_it_load_config_atributos";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_tipo", id_tipo);
                        cmd.Parameters.AddWithValue("@bit", 0);
                        dsAtributos1.findAtributos.Clear();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(dsAtributos1.findAtributos);
                        cn.Close();

                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        
        public frmTipoEquipos(ComportamientoCRUD pComportamientoActual, int pAtributoId)
        {
            InitializeComponent();
            //CargarAtributos();
            id_tipo = pAtributoId;
            this.ComportamientoActual = pComportamientoActual;
            TablesIDActual = new TipoEquipo();

            load_atributos_tipo_equipo();
            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                    txtIdSiguiente.Text = "1";
                    break;

                case ComportamientoCRUD.Update:
                    if (TablesIDActual.RecuperarRegistro(pAtributoId))
                    {
                       
                        txtCodigo.Text = TablesIDActual.codigo;
                        txtDescripcion.Text = TablesIDActual.descripcion;
                        txtDescripcionCompleta.Text = TablesIDActual.descripcion_mostrar;
                        txtIdSiguiente.Text = Convert.ToString(TablesIDActual.id_siguiente + 1);
                        txtCodigo.Text = TablesIDActual.codigo;
                        tggEnable.IsOn = TablesIDActual.enable;
                    }
                    break;

            }
        }

        private void frmTipoEquipos_Load(object sender, EventArgs e)
        {
            //int id_siguiente = 1;
            //txtIdSiguiente.Text = Convert.ToString(id_siguiente);
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

        //        dsAtributos1.findAtributos.Clear();
        //        adapter.Fill(dsAtributos1.findAtributos);
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        CajaDialogo.Error("Error:" + ex.Message);
        //    }
        //}

        private void cmdRegistrarItem_Click(object sender, EventArgs e)
        {
           
            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
            bool Guardar = false;
            
            bool habilitado = true;
            //if (string.IsNullOrEmpty(gleAtributos.Text))
            //{
            //    CajaDialogo.Error("Debe Seleccionar un Tipo de Dato!");
            //    return;
            //}

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe Ingresar un Nuevo atributo!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de crear este Atributo?");
            if (r != DialogResult.Yes)  
                return;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                    TablesIDActual.descripcion_mostrar = txtDescripcionCompleta.Text;
                    TablesIDActual.descripcion = txtDescripcion.Text;
                    TablesIDActual.enable = tggEnable.IsOn;
                    TablesIDActual.id_siguiente= dp.ValidateNumberInt32(txtIdSiguiente.Text);
                    TablesIDActual.codigo = txtCodigo.Text;
                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_setInsertNewMic_idSiguiente";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        cmd.Parameters.AddWithValue("@descripcion_mostrar", txtDescripcionCompleta.Text);
                        cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);
                        cmd.Parameters.AddWithValue("@id_siguiente", txtIdSiguiente.Text);
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);


                        int id_header_tipoEquipo = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsAtributos.findAtributosRow row in dsAtributos1.findAtributos.Rows)
                        {
                            if (row.seleccionado)
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_setInsertNewMic_configAtributoTipoEquipo";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_tipo_equipo", id_header_tipoEquipo);
                                cmd.Parameters.AddWithValue("@id_atributo", row.id);
                                cmd.Parameters.AddWithValue("@enable", habilitado);
                                cmd.ExecuteNonQuery();
                            }

                        }

                        transaction.Commit();
                        Guardar = true;

                        CajaDialogo.InformationAuto();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }


                    break;
                case ComportamientoCRUD.Update:
                    if (TablesIDActual.Recuperado)
                    {
                        TablesIDActual.descripcion_mostrar = txtDescripcionCompleta.Text;
                        TablesIDActual.descripcion = txtDescripcion.Text;
                        TablesIDActual.enable = tggEnable.IsOn;
                        TablesIDActual.id_siguiente = dp.ValidateNumberInt32(txtIdSiguiente.Text);
                        TablesIDActual.codigo = txtCodigo.Text;
                        //if (AtributoActual.UpdateRowAtributos())
                        //{
                        //    CajaDialogo.InformationAuto();
                        //    this.DialogResult = DialogResult.OK;
                        //    this.Close();
                        //}

                        
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");
                            
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "sp_setUpdate_TablesID";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            cmd.Parameters.AddWithValue("@descripcion_mostrar", txtDescripcionCompleta.Text);
                            cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);
                            cmd.Parameters.AddWithValue("@id_siguiente", txtIdSiguiente.Text);
                            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                            cmd.Parameters.AddWithValue("@id", id_tipo);


                            int id_header_tipoEquipo = Convert.ToInt32(cmd.ExecuteScalar());

                            foreach (dsAtributos.findAtributosRow row in dsAtributos1.findAtributos.Rows)
                            {
                                if (row.seleccionado)
                                {
                                    cmd.Parameters.Clear();
                                    cmd.CommandText = "sp_setupdateMic_configAtributoTipoEquipo";
                                    cmd.Connection = conn;
                                    cmd.Transaction = transaction;
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_tipo_equipo", id_tipo);
                                    cmd.Parameters.AddWithValue("@id_atributo", row.id);
                                    cmd.Parameters.AddWithValue("@enable", habilitado);
                                    //cmd.Parameters.AddWithValue("@id", );
                                    cmd.ExecuteNonQuery();
                                }

                            }

                            transaction.Commit();
                            Guardar = true;

                            CajaDialogo.InformationAuto();
                            this.DialogResult = DialogResult.OK;
                            this.Close();



                    }
                    else
                    {
                        CajaDialogo.Error("No se pudo cargar el atributo que desea editar!");
                        return;
                    }
                    break;


            }



            //try
            //{
            //    conn.Open();
            //    transaction = conn.BeginTransaction("Transaction Order");

            //    SqlCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = "sp_setInsertNewMic_idSiguiente";
            //    cmd.Connection = conn;
            //    cmd.Transaction = transaction;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@descripcion",txtDescripcion.Text );
            //    cmd.Parameters.AddWithValue("@descripcion_mostrar", txtDescripcionCompleta.Text);
            //    cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);
            //    cmd.Parameters.AddWithValue("@id_siguiente",id_siguiente);
            //    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);


            //    int id_header_tipoEquipo = Convert.ToInt32(cmd.ExecuteScalar());

            //    foreach (dsAtributos.findAtributosRow row in dsAtributos1.findAtributos.Rows)
            //    {
            //        if (row.seleccionado)
            //        {
            //            cmd.Parameters.Clear();
            //            cmd.CommandText = "sp_setInsertNewMic_configAtributoTipoEquipo";
            //            cmd.Connection = conn;
            //            cmd.Transaction = transaction;
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            cmd.Parameters.AddWithValue("@id_tipo_equipo",id_header_tipoEquipo);
            //            cmd.Parameters.AddWithValue("@id_atributo",row.id);
            //            cmd.Parameters.AddWithValue("@enable", habilitado);
            //            cmd.ExecuteNonQuery();
            //        }
                    
            //    }

            //    transaction.Commit();
            //    Guardar = true;

            //    this.DialogResult = DialogResult.OK;
            //    this.Close();

            //}
            //catch (Exception ec)
            //{
            //    transaction.Rollback();
            //    CajaDialogo.Error(ec.Message);
            //    Guardar = false;
            //}
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}