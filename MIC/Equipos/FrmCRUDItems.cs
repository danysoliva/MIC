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
using MIC.Equipos;

namespace MIC.Equipos
{
    public partial class FrmCRUDItems : DevExpress.XtraEditors.XtraForm
    {
        public TipoEquipo TablesIDActual;
        public int id_siguiente;
        DataOperations dp = new DataOperations();
        public enum ComportamientoCRUD
        {
           
            Insert = 1,
            Update = 2,
            
            //Date = 1,
            //Varchar = 2,
            //Numeric = 3,
            //Bit = 4,
        }

        ComportamientoCRUD ComportamientoActual;

        public Items ItemActual;
        
        public FrmCRUDItems()
        {
            InitializeComponent();
            CargarEstados();
            CargarTipoEquipo();
            CargarCodigo();
            CargarEstadosEquipos();
        }
        UserLogin UsuarioLogeado;  //Constructor
        public FrmCRUDItems(UserLogin pUser)
        {
            InitializeComponent();
            CargarEstados();
            CargarTipoEquipo(); CargarEstadosEquipos();
            UsuarioLogeado = pUser;

        }

        public void load_config_atributos_equipos()
        {
            string Query;
            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                    //Query = @"sp_it_load_config_atributos";
                    //try
                    //{
                    //    SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                    //    cn.Open();
                    //    SqlCommand cmd = new SqlCommand(Query, cn);
                    //    cmd.CommandType = CommandType.StoredProcedure;
                    //    cmd.Parameters.AddWithValue("@id_tipo", 0);
                    //    cmd.Parameters.AddWithValue("@bit", 1);
                    //    dsAtributos1.findAtributos.Clear();
                    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //    da.Fill(dsAtributos1.findAtributos);
                    //    cn.Close();

                    //}
                    //catch (Exception ex)
                    //{
                    //    CajaDialogo.Error(ex.Message);
                    //}
                    break;
                case ComportamientoCRUD.Update:
                    Query = @"sp_get_mic_config_atributos_equipos";
                    try
                    {
                        SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(Query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_item", ItemActual.id);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        dsItems1.AtributosEquipo.Clear();
                        adapter.Fill(dsItems1.AtributosEquipo);
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



        public FrmCRUDItems(ComportamientoCRUD pComportamientoActual, int pItemId)
        {
            InitializeComponent();
           
            this.ComportamientoActual = pComportamientoActual;
            ItemActual = new Items();
            CargarEstados();
            CargarTipoEquipo();
            CargarEstadosEquipos();


            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                     
                    Guardar = false;
                    break;

                case ComportamientoCRUD.Update:
                    if (ItemActual.RecuperarRegistro(pItemId))
                    {
                        
                        gleTipoEquipo.EditValue = ItemActual.id_tipo_equipo;
                        gleIdEstado.EditValue = ItemActual.id_estado;
                        txtItemCode.Text = ItemActual.items_code;
                        txtName.Text = ItemActual.nombre;   
                        txtMarca.Text = ItemActual.marca;
                        txtComentario.Text = ItemActual.comentario;
                        tggEnable.IsOn = ItemActual.enable;
                        tggBitAsignable.IsOn = ItemActual.bit_asignable;
                        load_config_atributos_equipos();
                        tggBitMultiusuario.IsOn = ItemActual.multiusuario;
                        gleEstadoEquipo.EditValue = ItemActual.estado_equipo;
                        
                    }
                    break;

            }



        }

        private void FrmCRUDItems_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

        }
        public void CargarIdSiguiente()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_get_id_siguiente_fromid", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@id_tipo_equipo", gleTipoEquipo.EditValue );
            id_siguiente = Convert.ToInt32(cmm.ExecuteScalar());
            con.Close();
        }
        public void CargarCodigo()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_get_itemcode_tablesID", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@tipo_Equipo", gleTipoEquipo.EditValue );
            string barcode = cmm.ExecuteScalar().ToString();
            txtItemCode.Text = barcode;
            con.Close();
        }

        private void CargarEstados()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_get_mic_estados_equipos", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.Mic_Estados_Equipos.Clear();
                adapter.Fill(dsItems1.Mic_Estados_Equipos);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void CargarEstadosEquipos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_get_mic_estados", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.estadosEquipos.Clear();
                adapter.Fill(dsItems1.estadosEquipos);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void CargarAtributosTiposEquipo()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_it_load_config_atributos_TipoEquipo", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_tipo",gleTipoEquipo.EditValue);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.AtributosEquipo.Clear();
                adapter.Fill(dsItems1.AtributosEquipo);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void CargarTipoEquipo()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_get_mic_tipo_equipo", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.tipoEquipo.Clear();
                adapter.Fill(dsItems1.tipoEquipo);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //SqlTransaction transaction = null;

            //SqlConnection conn = new SqlConnection(dp.ConnectionStringERP);
            //bool Guardar = false;

            //try
            //{
            //    conn.Open();
            //    transaction = conn.BeginTransaction("Transaction Order");

            //    SqlCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = "";
            //    cmd.Connection = conn;
            //    cmd.Transaction = transaction;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("",);
            //    cmd.Parameters.AddWithValue("", Istraslado ? Convert.ToDecimal(row.id_traslado) : 0);

            //    int id_header_estudiante = Convert.ToInt32(cmd.ExecuteScalar());

            //    foreach (dsEstudiantes.detalle_telefonosRow row in dsEstudiantes1.detalle_telefonos.Rows)
            //    {
            //        cmd.Parameters.Clear();
            //        cmd.CommandText = "";
            //        cmd.Connection = conn;
            //        cmd.Transaction = transaction;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("",);
            //        cmd.ExecuteNonQuery();
            //    }

            //    foreach (dsEstudiantes.detalle_rtnRow row in dsEstudiantes1.detalle_rtn.Rows)
            //    {
            //        cmd.Parameters.Clear();
            //        cmd.CommandText = "";
            //        cmd.Connection = conn;
            //        cmd.Transaction = transaction;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("",);
            //        cmd.ExecuteNonQuery();
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
        public bool Guardar;
        private void cmdRegistrarItem_Click(object sender, EventArgs e)
        {
            id_siguiente = id_siguiente + 1;
            
            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
            gleIdEstado.EditValue = 3;
            if (string.IsNullOrEmpty(gleEstadoEquipo.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Estado de equipo!");
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                CajaDialogo.Error("Debe Ingresar un Nombre!");
                return;
            }

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                CajaDialogo.Error("Debe Ingresar una marca!");
                return;
            }

            if (string.IsNullOrEmpty(txtComentario.Text))
            {
                CajaDialogo.Error("Debe Ingresar un Comentario!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de crear este Item?");
            if (r != DialogResult.Yes)
                return;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                    
                        ItemActual.id_estado = dp.ValidateNumberInt32(gleIdEstado.EditValue);
                        ItemActual.estado_equipo = dp.ValidateNumberInt32(gleEstadoEquipo.EditValue);
                        ItemActual.nombre = txtName.Text;
                        ItemActual.id_tipo_equipo = dp.ValidateNumberInt32(gleTipoEquipo.EditValue);
                        ItemActual.marca = txtMarca.Text;
                        ItemActual.comentario = txtComentario.Text;
                        ItemActual.enable = tggEnable.IsOn;
                        ItemActual.bit_asignable = tggBitAsignable.IsOn;
                        ItemActual.multiusuario = tggBitMultiusuario.IsOn;

                        try
                        {
                            conn.Open();
                            transaction = conn.BeginTransaction("Transaction Order");

                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "sp_setInsertNewMic_Items";
                            cmd.Connection = conn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@items_code", txtItemCode.Text);
                            cmd.Parameters.AddWithValue("@nombre", txtName.Text);
                            cmd.Parameters.AddWithValue("@id_tipo_equipo", gleTipoEquipo.EditValue);
                            cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);
                            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                            cmd.Parameters.AddWithValue("@bit_asignable", tggBitAsignable.IsOn);
                            cmd.Parameters.AddWithValue("@id_estado", gleIdEstado.EditValue);
                            cmd.Parameters.AddWithValue("@multiusuario", tggBitMultiusuario.IsOn);
                            cmd.Parameters.AddWithValue("@estado_equipo", gleEstadoEquipo.EditValue);



                            int id_header_item = Convert.ToInt32(cmd.ExecuteScalar());

                            foreach (dsItems.AtributosEquipoRow row in dsItems1.AtributosEquipo.Rows)
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_setInsertNewMic_Atributos_Equipos";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_item", id_header_item);
                                cmd.Parameters.AddWithValue("@id_atributo", row.id_atributo);

                                if (row.IsvalorDateNull())
                                {
                                    cmd.Parameters.Add("@valor_fecha", SqlDbType.DateTime).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_fecha", SqlDbType.DateTime).Value = row.valorDate;
                                }

                                if (row.IsvalorNumericNull())
                                {
                                    cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = row.valorNumeric;
                                }

                                if (row.IsvalorBitNull())
                                {
                                    cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = row.valorBit;
                                }

                                if (row.IsvalorVarcharNull())
                                {
                                    cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = row.valorVarchar;
                                }

                                //cmd.Parameters.AddWithValue("@valor_numerico", row.valorNumeric);
                                //cmd.Parameters.AddWithValue("@valor_bit", row.valorBit);
                                //cmd.Parameters.AddWithValue("@valor_varchar", row.valorVarchar);

                                cmd.ExecuteNonQuery();


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

                        try
                        {


                            SqlCommand command = new SqlCommand("sp_Update_Tables_Id", conn);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@id_tipo", gleTipoEquipo.EditValue);
                            command.Parameters.AddWithValue("@id_siguiente", id_siguiente);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            CajaDialogo.Error("Error: " + ex.Message);

                        }
                        //if (ItemActual.InsertRowItems())
                        //{
                        //    CajaDialogo.InformationAuto();
                        //    this.DialogResult = DialogResult.OK;
                        //    this.Close();
                        //}
                        
                    
                    
                    break;
                case ComportamientoCRUD.Update:
                    if (ItemActual.Recuperado)
                    {
                        ItemActual.id_estado = dp.ValidateNumberInt32(gleIdEstado.EditValue);
                        ItemActual.nombre = txtName.Text;
                        ItemActual.id_tipo_equipo = dp.ValidateNumberInt32(gleTipoEquipo.EditValue);
                        ItemActual.marca = txtMarca.Text;
                        ItemActual.comentario = txtComentario.Text;
                        ItemActual.enable = tggEnable.IsOn;
                        ItemActual.bit_asignable = tggBitAsignable.IsOn;
                        

                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_setUpdateItems";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@item_code", txtItemCode.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtName.Text);
                        cmd.Parameters.AddWithValue("@id_tipo_equipo", gleTipoEquipo.EditValue);
                        cmd.Parameters.AddWithValue("@enable", tggEnable.IsOn);
                        cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                        cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                        cmd.Parameters.AddWithValue("@bit_asignable", tggBitAsignable.IsOn);
                        cmd.Parameters.AddWithValue("@id_estado", gleIdEstado.EditValue);
                        cmd.Parameters.AddWithValue("@id", ItemActual.id);
                        cmd.Parameters.AddWithValue("@multiusuario", tggBitMultiusuario.IsOn);
                        cmd.Parameters.AddWithValue("@estado_equipo", gleEstadoEquipo.EditValue);


                        int id_header_tipoEquipo = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsItems.AtributosEquipoRow row in dsItems1.AtributosEquipo.Rows)
                        {
                            if (row.IsidNull())
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_setInsertNewMic_Atributos_Equipos";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_item",ItemActual.id );
                                cmd.Parameters.AddWithValue("@id_atributo", row.id_atributo);

                                if (row.IsvalorDateNull())
                                {
                                    cmd.Parameters.Add("@valor_fecha", SqlDbType.DateTime).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_fecha", SqlDbType.DateTime).Value = row.valorDate;
                                }

                                if (row.IsvalorNumericNull())
                                {
                                    cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = row.valorNumeric;
                                }

                                if (row.IsvalorBitNull())
                                {
                                    cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = row.valorBit;
                                }

                                if (row.IsvalorVarcharNull())
                                {
                                    cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = row.valorVarchar;
                                }

                                //cmd.Parameters.AddWithValue("@valor_numerico", row.valorNumeric);
                                //cmd.Parameters.AddWithValue("@valor_bit", row.valorBit);
                                //cmd.Parameters.AddWithValue("@valor_varchar", row.valorVarchar);

                                cmd.ExecuteNonQuery();

                            }
                            else
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_mic_setUpdate_atributos_equipos";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id", row.id);
                                cmd.Parameters.AddWithValue("@id_atributo", row.id_atributo);
                                cmd.Parameters.AddWithValue("@id_item", ItemActual.id);

                                //cmd.Parameters.AddWithValue("@id", );

                                if (row.IsvalorNumericNull())
                                {
                                    cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = row.valorNumeric;
                                }

                                if (row.IsvalorBitNull())
                                {
                                    cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = row.valorBit;
                                }

                                if (row.IsvalorDateNull())
                                {
                                    cmd.Parameters.Add("@valor_date", SqlDbType.DateTime).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_date", SqlDbType.DateTime).Value = row.valorDate;
                                }

                                if (row.IsvalorVarcharNull())
                                {
                                    cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = DBNull.Value;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = row.valorVarchar;
                                }
                                cmd.ExecuteNonQuery();
                            }

                        }
                            
                          //cmd.Parameters.Clear();
                          //cmd.CommandText = "sp_mic_setUpdate_atributos_equipos";
                          //cmd.Connection = conn;
                          //cmd.Transaction = transaction;
                          //cmd.CommandType = CommandType.StoredProcedure;
                          //cmd.Parameters.AddWithValue("@id", row.id);
                          //cmd.Parameters.AddWithValue("@id_atributo", row.id_atributo);
                          //cmd.Parameters.AddWithValue("@id_item", ItemActual.id);
                        
                          //  //cmd.Parameters.AddWithValue("@id", );

                          //  if (row.IsvalorNumericNull())
                          //  {
                          //      cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = DBNull.Value;
                          //  }
                          //  else
                          //  {
                          //      cmd.Parameters.Add("@valor_numerico", SqlDbType.Decimal).Value = row.valorNumeric;
                          //  }

                          //  if (row.IsvalorBitNull())
                          //  {
                          //      cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = DBNull.Value;
                          //  }
                          //  else
                          //  {
                          //      cmd.Parameters.Add("@valor_bit", SqlDbType.Bit).Value = row.valorBit;
                          //  }

                          //  if (row.IsvalorDateNull())
                          //  {
                          //      cmd.Parameters.Add("@valor_date", SqlDbType.DateTime).Value = DBNull.Value;
                          //  }
                          //  else
                          //  {
                          //      cmd.Parameters.Add("@valor_date", SqlDbType.DateTime).Value = row.valorDate;
                          //  }

                          //  if (row.IsvalorVarcharNull())
                          //  {
                          //      cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = DBNull.Value;
                          //  }
                          //  else
                          //  {
                          //      cmd.Parameters.Add("@valor_varchar", SqlDbType.VarChar).Value = row.valorVarchar;
                          //  }
                          //  cmd.ExecuteNonQuery();
                                
                        

                        transaction.Commit();
                        Guardar = true;

                        CajaDialogo.InformationAuto();
                        this.DialogResult = DialogResult.OK;
                        this.Close();


                        //ItemActual.id_estado = dp.ValidateNumberInt32(gleIdEstado.EditValue);
                        //ItemActual.nombre = txtName.Text;
                        ////ItemActual.id_tipo_equipo = txtIdTipoEquipo;
                        //ItemActual.marca = txtMarca.Text;
                        //ItemActual.comentario = txtComentario.Text;
                        //ItemActual.enable = tggEnable.IsOn;
                        //ItemActual.bit_asignable = tggBitAsignable.IsOn;
                        //if (ItemActual.UpdateRowItems())
                        //{
                        //    CajaDialogo.InformationAuto();
                        //    this.DialogResult = DialogResult.OK;
                        //    this.Close();
                        //}
                    }
                    else
                    {
                        CajaDialogo.Error("No se pudo cargar el atributo que desea editar!");
                        return;
                    }
                    break;

            }
        }

        private void cmdAgregarAtributo_Click(object sender, EventArgs e)
        {

            findAtributos frm = new findAtributos(Convert.ToInt32(gleTipoEquipo.EditValue), UsuarioLogeado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsItems.AtributosEquipoRow row1 = dsItems1.AtributosEquipo.NewAtributosEquipoRow();

                var gridView2 = (GridView)gridControlAtributos.FocusedView;

                row1.id_atributo = frm.id_selected;
                row1.descripcion = frm.atributo;
                row1.idTipoDato = frm.tipoDato;
                //if (frm.AtributoActual.Discontinued)
                //    row1.IsDiscontinued = "Si";
                //else
                //    row1.IsDiscontinued = "No";

                dsItems1.AtributosEquipo.AddAtributosEquipoRow(row1);
                dsAtributos1.AcceptChanges();
                


            }
         }

            private void gleTipoEquipo_EditValueChanged(object sender, EventArgs e)
             {

                switch (ComportamientoActual)
                {
                    case ComportamientoCRUD.Insert:
                         CargarAtributosTiposEquipo();
                         CargarCodigo();
                         CargarIdSiguiente();
                    break;

                    case ComportamientoCRUD.Update:
                     CargarCodigo();
                     CargarIdSiguiente();
                    break;

                }
              }


        public bool inserted = false;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int tipoDato;
            String valorVarchar;
            Decimal valorNumeric;
            bool valorBool;
            DateTime valorDate;
            string dato;
            


            var gridView = (GridView)gridControlAtributos.FocusedView;
            var row = (dsItems.AtributosEquipoRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();

            tipoDato = dp.ValidateNumberInt32(row.idTipoDato);

            if (row.IsvalorDateNull())
            {
                valorDate = DateTime.Today;
                  
            }
            else
            {
                valorDate = row.valorDate;
                
            }

            if (row.IsvalorVarcharNull())
            {
                valorVarchar = "";
                
            }
            else
            {
                valorVarchar = row.valorVarchar;
                
            }

            if (row.IsvalorNumericNull())
            {
                valorNumeric = 0;
               
            }
            else
            {
                valorNumeric = row.valorNumeric;
                
            }

            if (row.IsvalorBitNull())
            {
                valorBool = false;
               
            }
            else
            {
                valorBool = row.valorBit;
                
            }

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                   


                    if (inserted == false)
                    {
                        foreach (dsItems.AtributosEquipoRow row1 in dsItems1.AtributosEquipo.Rows)
                        {

                            switch (row1.idTipoDato)
                            {
                                case 2:

                                    frmAddAtributo frm = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Varchar, 0, row1.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                    if (frm.ShowDialog() == DialogResult.OK)
                                    {

                                        row1.valorVarchar = frm.valorVarchar;
                                        row1.dato = frm.valorVarchar;

                                    }
                                    break;
                                case 3:
                                    frmAddAtributo frm1 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Numeric, 0, row1.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                    if (frm1.ShowDialog() == DialogResult.OK)
                                    {
                                        row1.valorNumeric = frm1.valorNumeric;
                                        row1.dato = Convert.ToString(frm1.valorNumeric);

                                    }

                                    break;
                                case 4:
                                    frmAddAtributo frm2 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Bit, 0, row1.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                    if (frm2.ShowDialog() == DialogResult.OK)
                                    {

                                        row1.valorBit = frm2.valorBool;
                                        row1.dato = Convert.ToString(frm2.valorBool);

                                    }
                                    break;
                                case 1:
                                    frmAddAtributo frm3 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Fecha, 0, row1.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                    if (frm3.ShowDialog() == DialogResult.OK)
                                    {

                                        row1.valorDate = frm3.valorDate;
                                        row1.dato = String.Format("{0:d}", frm3.valorDate);

                                    }
                                    break;
                                default:
                                    break;
                                
                            }

                            inserted = true;
                        }

                    }
                    else
                    {
                        switch (row.idTipoDato)
                        {
                            case 2:

                                frmAddAtributo frm = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Varchar, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                if (frm.ShowDialog() == DialogResult.OK)
                                {

                                    row.valorVarchar = frm.valorVarchar;
                                    row.dato = frm.valorVarchar;

                                }
                                break;
                            case 3:
                                frmAddAtributo frm1 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Numeric, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                if (frm1.ShowDialog() == DialogResult.OK)
                                {
                                    row.valorNumeric = frm1.valorNumeric;
                                    row.dato = Convert.ToString(frm1.valorNumeric);

                                }

                                break;
                            case 4:
                                frmAddAtributo frm2 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Bit, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                if (frm2.ShowDialog() == DialogResult.OK)
                                {

                                    row.valorBit = frm2.valorBool;
                                    row.dato = Convert.ToString(frm2.valorBool);

                                }
                                break;
                            case 1:
                                frmAddAtributo frm3 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Fecha, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                                if (frm3.ShowDialog() == DialogResult.OK)
                                {

                                    row.valorDate = frm3.valorDate;
                                    row.dato = String.Format("{0:d}", frm3.valorDate);

                                }
                                break;
                            default:
                                break;

                        }
                    }

                    
                    

                break;

                case ComportamientoCRUD.Update:

                    switch (tipoDato)
                    {
                        case 2:

                            frmAddAtributo frm = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Varchar, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {

                                row.valorVarchar = frm.valorVarchar;
                                row.dato = frm.valorVarchar;

                            }
                            break;
                        case 3:
                            frmAddAtributo frm1 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Numeric, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                            if (frm1.ShowDialog() == DialogResult.OK)
                            {
                                row.valorNumeric = frm1.valorNumeric;
                                row.dato = Convert.ToString(frm1.valorNumeric);

                            }

                            break;
                        case 4:
                            frmAddAtributo frm2 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Bit, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                            if (frm2.ShowDialog() == DialogResult.OK)
                            {

                                row.valorBit = frm2.valorBool;
                                row.dato = Convert.ToString(frm2.valorBool);

                            }
                            break;
                        case 1:
                            frmAddAtributo frm3 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Fecha, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
                            if (frm3.ShowDialog() == DialogResult.OK)
                            {

                                row.valorDate = frm3.valorDate;
                                row.dato = String.Format("{0:d}", frm3.valorDate);

                            }
                            break;
                        default:
                            break;

                    }
                    
                    break;

            }

           
            

                
            //switch (tipoDato){ 
            //    case 2:

            //        frmAddAtributo frm = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Varchar, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {

            //            row.valorVarchar = frm.valorVarchar;
            //            row.dato = frm.valorVarchar;
                       
            //        }
            //        break;
            //    case 3:
            //        frmAddAtributo frm1 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Numeric, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
            //        if (frm1.ShowDialog() == DialogResult.OK)
            //        {
            //            row.valorNumeric= frm1.valorNumeric;
            //            row.dato = Convert.ToString(frm1.valorNumeric);
                        
            //        }

            //        break;
            //    case 4:
            //        frmAddAtributo frm2 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Bit, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
            //        if (frm2.ShowDialog() == DialogResult.OK)
            //        {

            //            row.valorBit = frm2.valorBool;
            //            row.dato = Convert.ToString(frm2.valorBool);
                       
            //        }
            //        break;
            //    case 1:
            //        frmAddAtributo frm3 = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Fecha, 0, row.descripcion, valorDate, valorVarchar, valorNumeric, valorBool);
            //        if (frm3.ShowDialog() == DialogResult.OK)
            //        {

            //            row.valorDate = frm3.valorDate;
            //            row.dato = String.Format("{0:d}", frm3.valorDate); 
                        
            //        }
            //        break;
            //    default:
            //        break;
            }

            //frmAddAtributo frm = new frmAddAtributo(frmAddAtributo.ComportamientoCRUD.Varchar, (row.tipoDato));
            //if (frm.ShowDialog() == DialogResult.OK)
            //{

            //    if (row.id == row.id)
            //    {

            //        //row.id = frm.TablesIDActual.id;
            //        //row.descripcion = frm.TablesIDActual.descripcion;
            //        //row.enable = frm.TablesIDActual.enable;
            //        //row.descripcion_mostrar = frm.TablesIDActual.descripcion_mostrar;
            //        //row.id_siguiente = frm.TablesIDActual.id_siguiente;
            //        //row.codigo = frm.TablesIDActual.codigo;


            //        //if (frm.AtributoActual.Discontinued)
            //        //    row.IsDiscontinued = "Si";
            //        //else
            //        //    row.IsDiscontinued = "No";

            //        //dsAtributos1.AcceptChanges();

            //    }
            //}
        }

        
    }
