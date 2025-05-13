using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MIC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC.Equipos
{
    public partial class frmDiagnosticoEquipos : DevExpress.XtraEditors.XtraForm
    {
        public int id_item, id_diagnos;
        //public enum TipoTransaccionSQL
        //{
        //    Insert = 1, Update = 2, Delete = 3
        //}

        //TipoTransaccionSQL TipoTransaccionSQL_Actual;

        public Diagnosticos DiagnosticoActual;
        public frmDiagnosticoEquipos(ComportamientoCRUD pComportamientoActual,int pItemId, int pId_Dignos, UserLogin pUser)
        {
            InitializeComponent();
            ItemActual = new Items();
            DiagnosticoActual = new Diagnosticos();
            id_item = pItemId;
            id_diagnos = pId_Dignos;
            UsuarioLogeado = pUser;
            CargarUsersByItem();
            this.ComportamientoActual = pComportamientoActual;
            

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Nuevo:
                    if (ItemActual.RecuperarRegistro(pItemId))
                    {
                        CargarTipoEquipo();

                        load_data();
                        gleTipoEquipo.EditValue = ItemActual.id_tipo_equipo;
                        txtItemCode.Text = ItemActual.items_code;

                        txtName.Text = ItemActual.nombre;
                        CargarUbicacion();
                        CargarUbicacionGeneral();

                        load_informacion();
                        CargarUser();

                    }

                    break;

                case ComportamientoCRUD.View:
                    if (DiagnosticoActual.RecuperarRegistro(pId_Dignos))
                    {
                        load_data();
                        
                        CargarTipoEquipo();
                        CargarDetalleAtributosDiagnostico();
                        LoadArchivosAdj();
                        cmdGuardar.Visible = false;
                        btnDelete.Buttons[0].Enabled = false;
                        cmdUpload.Enabled = false; 
                        txtName.Text = DiagnosticoActual.equipo;
                        gleTipoEquipo.EditValue = DiagnosticoActual.tipoEquipo;
                        gleUser.EditValue = DiagnosticoActual.idUsuario;
                        gleRelevancia.Text = DiagnosticoActual.relevancia;
                        txtDepartamento.Text = DiagnosticoActual.ubicacionGeneral;
                        txtUbicacion.Text = DiagnosticoActual.ubicacionEspecifica;
                        rxtReporte.Text = DiagnosticoActual.falla;
                        rxtDiagnostico.Text = DiagnosticoActual.diagnostico;


                    }
                    
                    

                    break;
                case ComportamientoCRUD.Update:
                    if (DiagnosticoActual.RecuperarRegistro(pId_Dignos))
                    {
                        load_data();

                        CargarTipoEquipo();
                        CargarDetalleAtributosDiagnostico();
                        LoadArchivosAdj();
                        cmdGuardar.Visible = true;
                        btnDelete.Buttons[0].Enabled = true;
                        cmdUpload.Enabled = true;
                        txtName.Text = DiagnosticoActual.equipo;
                        gleTipoEquipo.EditValue = DiagnosticoActual.tipoEquipo;
                        gleUser.EditValue = DiagnosticoActual.idUsuario;
                        gleRelevancia.Text = DiagnosticoActual.relevancia;
                        txtDepartamento.Text = DiagnosticoActual.ubicacionGeneral;
                        txtUbicacion.Text = DiagnosticoActual.ubicacionEspecifica;
                        rxtReporte.Text = DiagnosticoActual.falla;
                        rxtDiagnostico.Text = DiagnosticoActual.diagnostico;


                    }



                    break;

            }


        }
        
        DataOperations dp = new DataOperations();
        public Items ItemActual;
        UserLogin UsuarioLogeado;
        SqlTransaction transaction = null;

        ComportamientoCRUD ComportamientoActual;
        public enum ComportamientoCRUD
        {

            Nuevo = 1,
            View = 2,
            Update = 3

            //Date = 1,
            //Varchar = 2,
            //Numeric = 3,
            //Bit = 4,
        }
        public frmDiagnosticoEquipos()
        {
            load_data();
            InitializeComponent();

            CargarUser();

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
                cn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void LoadArchivosAdj()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_mic_get_archivos_subidos_by_diagnostico", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_diagnostico", id_diagnos);
                dsItems1.archivos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsItems1.archivos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void CargarDetalleAtributosDiagnostico()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_it_load_detalle_atributos_diagnosticos", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pid", id_diagnos);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.detalleEquipo.Clear();
                adapter.Fill(dsItems1.detalleEquipo);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }
        private void CargarUsersByItem()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_user_by_item", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_item", id_item);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.users.Clear();
                adapter.Fill(dsItems1.users);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        public void CargarUser()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_get_user_by_item", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@id_item", id_item);
            string user = cmm.ExecuteScalar().ToString();
            if (user=="1")
            {
                gleUser.EditValue = "No Asignado";
            }
            gleUser.EditValue = user;
            con.Close();
        }
        public void CargarUbicacion()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_get_mic_ubicacion_esp_from_id", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@pid", id_item);
            string barcode = cmm.ExecuteScalar().ToString();
            txtUbicacion.Text = barcode;
            con.Close();
        }
        public void CargarUbicacionGeneral()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_get_mic_ubicacion_from_id", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@pid", id_item);
            string barcode = cmm.ExecuteScalar().ToString();
            txtDepartamento.Text = barcode;
            con.Close();
        }
        private void CargarTipoEquipo()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_mic_tipo_equipo", connection);
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
        public void load_informacion()
        {
            string Query = @"mic_report_atributos_equipos_diagnostico";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_item", id_item);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsItems1.detalleEquipo.Clear();
                da.Fill(dsItems1.detalleEquipo);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            string pathFile, fileName;
            if (string.IsNullOrEmpty(gleRelevancia.Text))
            {
                CajaDialogo.Error("Debe Seleccionar una relevancia");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de crear este Diagnostico?");
            if (r != DialogResult.Yes)
                return;


            SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
            try
            {

                cn.Open();
                transaction = cn.BeginTransaction("Transaction Order");

                SqlCommand cmd = cn.CreateCommand();
                switch (ComportamientoActual)
                {
                    case ComportamientoCRUD.Nuevo:
                        cmd.CommandText = "sp_setInsertNewMic_Diagnosticos";
                        cmd.Connection = cn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idEquipo", id_item);
                        cmd.Parameters.AddWithValue("@equipo", txtName.Text);
                        cmd.Parameters.AddWithValue("@idUsuario", gleUser.EditValue);
                        cmd.Parameters.AddWithValue("@usuario", gleUser.Text);
                        cmd.Parameters.AddWithValue("@tipoEquipo", gleTipoEquipo.EditValue);
                        cmd.Parameters.AddWithValue("@relevancia", gleRelevancia.Text);
                        cmd.Parameters.AddWithValue("@ubicacionGeneral", txtDepartamento.Text);
                        cmd.Parameters.AddWithValue("@ubicacionEspecifica", txtUbicacion.Text);
                        cmd.Parameters.AddWithValue("@falla", rxtReporte.Text);
                        cmd.Parameters.AddWithValue("@diagnostico", rxtDiagnostico.Text);
                        cmd.Parameters.AddWithValue("@encargadoIT", UsuarioLogeado.Id);

                        int id_header_diag = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsItems.detalleEquipoRow row in dsItems1.detalleEquipo.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_setInsertNewDetalleAtributosDiagnostico";
                            cmd.Connection = cn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@atributo", row.atributo);
                            cmd.Parameters.AddWithValue("@descripcion", row.dato);
                            cmd.Parameters.AddWithValue("@id_diagnostico", id_header_diag);

                            cmd.ExecuteNonQuery();
                        }

                        foreach (dsItems.archivosRow row in dsItems1.archivos.Rows)
                        {
                            pathFile = Convert.ToString(row["path"]);
                            fileName = Convert.ToString(row["fileName"]);
                            cmd.Parameters.Clear();
                            cmd.CommandText = "sp_setInsertNewArchivoAdjuntoDiagnostico";
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@path", dp.FTP_MIC_DIAG + row["fileName"]);
                            cmd.Parameters.AddWithValue("@file_name", row.fileName);
                            cmd.Parameters.AddWithValue("@id_item", id_item);
                            cmd.Parameters.AddWithValue("@id_diagnostico", id_header_diag);

                            cmd.ExecuteNonQuery();

                            Upload(pathFile, fileName);
                        }
                        break;
                    case ComportamientoCRUD.Update:

                        cmd.CommandText = "[sp_setUpdateMic_Diagnosticos]";
                        cmd.Connection = cn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idEquipo", id_item);
                        cmd.Parameters.AddWithValue("@equipo", txtName.Text);
                        cmd.Parameters.AddWithValue("@idUsuario", gleUser.EditValue);
                        cmd.Parameters.AddWithValue("@usuario", gleUser.Text);
                        cmd.Parameters.AddWithValue("@tipoEquipo", gleTipoEquipo.EditValue);
                        cmd.Parameters.AddWithValue("@relevancia", gleRelevancia.Text);
                        cmd.Parameters.AddWithValue("@ubicacionGeneral", txtDepartamento.Text);
                        cmd.Parameters.AddWithValue("@ubicacionEspecifica", txtUbicacion.Text);
                        cmd.Parameters.AddWithValue("@falla", rxtReporte.Text);
                        cmd.Parameters.AddWithValue("@diagnostico", rxtDiagnostico.Text);
                        cmd.Parameters.AddWithValue("@encargadoIT", UsuarioLogeado.Id);
                        cmd.Parameters.AddWithValue("@id_diagnostico", id_diagnos);
                        

                        foreach (dsItems.detalleEquipoRow row in dsItems1.detalleEquipo.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "[sp_setUpdateDetalleAtributosDiagnostico]";
                            cmd.Connection = cn;
                            cmd.Transaction = transaction;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@atributo", row.atributo);
                            cmd.Parameters.AddWithValue("@descripcion", row.dato);
                            cmd.Parameters.AddWithValue("@id_diagnostico", id_diagnos);
                            cmd.Parameters.AddWithValue("@id_atributo", row.id);

                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case ComportamientoCRUD.View:
                        //Solo es para ver no debemos actualizar ni agregar nada.
                        break;
                    default:
                        break;
                }
                

                transaction.Commit();
                CajaDialogo.InformationAuto();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                CajaDialogo.Error(ex.Message);
            }



        }

        private void cmdUpload_Click(object sender, EventArgs e)
        {
            string pathFile, fileName;
            DataOperations dp = new DataOperations();

            Dialog.InitialDirectory = "C:/";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {

                dsItems.archivosRow row1 = dsItems1.archivos.NewarchivosRow();
                //DataRow row = dsItems1.archivos.NewRow();
                //row["path"] = Dialog.FileName;
                //row["fileName"] = Dialog.SafeFileName;

                row1["path"]=Dialog.FileName;
                row1["fileName"] = Dialog.SafeFileName;

                //pathFile = Convert.ToString(row["path"]);
                //fileName = Convert.ToString(row["fileName"]);

                pathFile = Convert.ToString(row1["path"]);
                fileName = Convert.ToString(row1["fileName"]);

                dsItems1.archivos.AddarchivosRow(row1);

            }

        }

        private void btnOpen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
             { 
                
                var row = (dsItems.archivosRow)grdv_seguimiento.GetFocusedDataRow();
                if (row.IsidNull())
                {
                    if (System.IO.File.Exists(row.path))
                    {
                        Process.Start(row.path);
                    }
                }
                else
                {
                    OpenFile(row.path, row.fileName);
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void OpenFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string user_ = string.Empty;
                string pass_ = string.Empty;

                if(string.IsNullOrEmpty(UsuarioLogeado.Pass))
                {
                    user_ = "operador";
                    pass_ = "Tempo1234";
                }
                else
                {
                    user_ = UsuarioLogeado.ADuser1;
                    pass_ = UsuarioLogeado.Pass;
                }

                request.Credentials = new NetworkCredential(user_, pass_);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {

                    ftpStream.CopyTo(fileStream);

                    Process.Start(pathDestination);

                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var row = (dsItems.archivosRow)grdv_seguimiento.GetFocusedDataRow();
                if (row.IsidNull())
                {
                    grdv_seguimiento.DeleteRow(grdv_seguimiento.FocusedRowHandle);
                    dsItems1.AcceptChanges();
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void DownloadFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string user_ = string.Empty;
                string pass_ = string.Empty;

                if (string.IsNullOrEmpty(UsuarioLogeado.Pass))
                {
                    user_ = "operador";
                    pass_ = "Tempo1234";
                }
                else
                {
                    user_ = UsuarioLogeado.ADuser1;
                    pass_ = UsuarioLogeado.Pass;
                }

                request.Credentials = new NetworkCredential(user_, pass_);
                //request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
                
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(pathDestination))
                {

                    ftpStream.CopyTo(fileStream);
                    CajaDialogo.InformationDownload();

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void btnDescargar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string pathdDestination;
                var gv = (GridView)gridControlAdjuntos.FocusedView;
                var row = (dsItems.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);
                saveFileDialog1.FileName = row.fileName;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathdDestination = Path.GetDirectoryName(saveFileDialog1.FileName);
                    DownloadFile(row.path, pathdDestination + @"\" + row.fileName);//+ @"\" + row.fileName
                    //CajaDialogo.Information(xtraFolderBrowserDialog1.SelectedPath);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Upload(string pathFile, string fileName)
        {
            try
            {
                if (string.IsNullOrEmpty(pathFile) || string.IsNullOrEmpty(fileName))
                {
                    CajaDialogo.Error("No se cargo el archivo!");
                    return false;
                }
                else
                {
                    DataOperations dp = new DataOperations();

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_MIC_DIAG + fileName);//crear el archivo en el server

                    string user_ = string.Empty; 
                    string passwd = string.Empty;

                    if (string.IsNullOrEmpty(UsuarioLogeado.Pass))
                    {
                        user_ = "operador";
                        passwd = "Tempo1234";
                    }
                    else
                    {
                        user_ = UsuarioLogeado.ADuser1;
                        passwd = UsuarioLogeado.Pass;
                    }

                    //request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
                    request.Credentials = new NetworkCredential(user_, passwd);
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead(pathFile))//del pc local la ruta
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }
    }
}