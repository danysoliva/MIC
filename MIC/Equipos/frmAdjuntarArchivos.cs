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
    public partial class frmAdjuntarArchivos : DevExpress.XtraEditors.XtraForm
    {
        DataOperations dp = new DataOperations();
        int id_item;
        int id_user;
        public frmAdjuntarArchivos()
        {
            InitializeComponent();
        }
        public frmAdjuntarArchivos(int pId_item, UserLogin pUser)
        {
            InitializeComponent();
            id_item = pId_item;
            UsuarioLogeado = pUser;
            //LoadArchivosAdj()
            LoadArchivosAdj();
        }
        UserLogin UsuarioLogeado;
        SqlTransaction transaction;

        private void LoadArchivosAdj()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_mic_get_archivos_subidos_by_item", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_item", id_item);
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
        public void CargarIdUser()
        {
            SqlConnection con = new SqlConnection(dp.ConnectionStringDEMO);
            con.Open();
            SqlCommand cmm = new SqlCommand("sp_get_one_user_by_item", con);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@id_item", id_item);
            string barcode = cmm.ExecuteScalar().ToString();
            id_user= Convert.ToInt32(barcode);
            con.Close();
        }
        private void OpenFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                //request.Credentials = new NetworkCredential(dp.User_FTP_Server, dp.Password_UserFTPServer);
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

                //request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass, "AQUAFEEDHN.COM");
                request.Credentials = new NetworkCredential(user_, pass_, "AQUAFEEDHN.COM");
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

        private void DownloadFile(string pathSource, string pathDestination)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
                //request.Credentials = new NetworkCredential(UsuarioLogeado.AD_User, UsuarioLogeado.Password);
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

        private void cmdNuevoAtributo_Click(object sender, EventArgs e)
        {
            string pathFile, fileName;
            DataOperations dp = new DataOperations();

            Dialog.InitialDirectory = "C:/";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                DataRow row = dsItems1.archivos.NewRow();
                row["path"] = Dialog.FileName;
                row["fileName"] = Dialog.SafeFileName;

                pathFile = Convert.ToString(row["path"]);
                fileName = Convert.ToString(row["fileName"]);
                
                try
                {
                   
                    string Query = @"sp_setInsertNewArchivoAdjunto";
                    SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(Query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@file_name", row["fileName"]);
                    cmd.Parameters.AddWithValue("@path", dp.FTP_MIC + row["fileName"]);
                    cmd.Parameters.AddWithValue("@descripcion", row["fileName"]);
                    cmd.Parameters.AddWithValue("@id_item", id_item);
                   

                    cmd.ExecuteNonQuery();
                    //if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                    //{

                    //    if (MessageBox.Show("Operacion Exitosa, Desea salir del formulario?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    //    {
                    //        cn.Close();
                    //        this.DialogResult = DialogResult.OK;
                    //        this.Close();
                    //    }
                    //    else
                    //    {
                    //        cn.Close();

                    //    }

                    //}
                    CajaDialogo.InformationAuto();
                    Upload(pathFile, fileName);
                    LoadArchivosAdj();
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error(ex.Message);
                }
                //CajaDialogo.InformationAuto();
                //Upload(pathFile, fileName);
                //LoadArchivosAdj();

            }

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

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_MIC + fileName);//crear el archivo en el server
                    request.Credentials = new NetworkCredential(UsuarioLogeado.ADuser1, UsuarioLogeado.Pass);
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

        private void btnOpen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string dir = @"C:\APMS_IT";
                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }


                var gv = (GridView)gridControlAdjuntos.FocusedView;
                var row = (dsItems.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);


                OpenFile(row.path, dir + @"\" + row.fileName);
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

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gv = (GridView)gridControlAdjuntos.FocusedView;
            var row = (dsItems.archivosRow)gv.GetDataRow(gv.FocusedRowHandle);
            DialogResult r = CajaDialogo.Pregunta("Se eliminara el archivo de forma permanente! esta seguro?");
            if (r == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
                conn.Open();
                try
                { 
                    SqlCommand command = new SqlCommand("sp_update_mic_archivos_adjuntos_by_enable", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", row.id);
                    command.ExecuteNonQuery();
                    CajaDialogo.Information("Archivo borrado con exito!");
                    LoadArchivosAdj();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    CajaDialogo.Error("Error: " + ex.Message);

                }
            }
        }
    }
}