using DevExpress.XtraEditors;
using MIC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private frmContenedorGeneral frmContenedorPrincipal;
        public frmLogin(frmContenedorGeneral pfrmContenedorPrincipal)
        {
            InitializeComponent();
            frmContenedorPrincipal = pfrmContenedorPrincipal;
        }
        public int IdUser;
        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //login
            string user;
            string pass;
            string domian;
            if (txtUsuario.Text != "")
            {
                user = txtUsuario.Text;
            }
            else
            {
                // MessageBox.Show("Usuario Vacio.");
                CajaDialogo.Error("Debe ingresar un nombre de usuario ejemplo: maria.perez");
                return;
            }
            if (txtClave.Text != "")
            {
                pass = txtClave.Text;
            }
            else
            {
                CajaDialogo.Error("Ingrese su contraseña");
                return;
            }

            Security sc = new Security();
            domian = "AQUAFEEDHN";
            if (sc.Validate_Account(domian, user, pass))
            {

                //MessageBox.Show("Exito");
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);

                int TiempoP = 300;
                //administracion.Huellas.frmProcesando frmProceso = new administracion.Huellas.frmProcesando();
                SplashForm frmProceso = new SplashForm();
                try
                {
                    con.Open();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                frmProceso.ShowDialog();
                Thread.Sleep(TiempoP);
                frmProceso.Close();


                UserLogin Log1 = new UserLogin();
                if (Log1.RecuperarRegistroFromUser(user))
                {
                    string HostName = Dns.GetHostName();
                    string DBActive = Globals.CONN_ActiveDB;
                    string IPAddress = "0.0.0.0";
                    var host = Dns.GetHostEntry(HostName);

                    foreach (var ip in host.AddressList)
                    {
                        if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            IPAddress = ip.ToString();
                        }
                    }

                    try
                    {
                        //Guardar Log de Inicio de Sesion
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_insert_login_user_mic", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_user", Log1.Id);
                        cmd.Parameters.AddWithValue("@pc_conexion", HostName);
                        cmd.Parameters.AddWithValue("@ip_conexion", IPAddress);
                        cmd.Parameters.AddWithValue("@database_conexion", DBActive);
                        cmd.Parameters.AddWithValue("@id_grupo", Log1.IdGrupo);
                        cmd.Parameters.AddWithValue("@version", AssemblyVersion);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                    Log1.Pass = txtClave.Text;
                    Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
                    //frmOpcionesMIC_BK frm = new frmOpcionesMIC_BK(Log1);
                    //if (this.MdiParent != null)
                    //    frm.MdiParent = this.MdiParent;

                    frmContenedorPrincipal.LlamarEvento(Log1);
                    this.Close();
                    //frm.Show();

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    CajaDialogo.Error("Usuario No encontrado en AQUAFEEDHN.COM");
                }
            }
            else
            {
                CajaDialogo.Error("Usuario y contraseña invalidos");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string HostName = Dns.GetHostName();
            if (HostName == "7L12TV3" /*Danys Oliva*/ || HostName == "9SSCBV2" /*Ever Erazo*/|| HostName == "6G1SST3" /*Ruben Garcia */ || HostName == "F9Q11Q2")
            {
                cmdAdmin.Visible = true;
                if (HostName == "7L12TV3")
                {
                    IdUser = 1035;
                }
                //else if (HostName == "9SSCBV2")
                //{
                //    IdUser = 1137;
                //}
                //else if (HostName == "6G1SST3")
                //{
                //    IdUser = 1058;
                //}
                //else
                //{
                //    IdUser = 1104;
                //}
            }
            else
            {
                cmdAdmin.Visible = false;
            }


        }

        public string AssemblyVersion
        {
            get
            {
                //return ApplicationDeployment.CurrentDeployment.CurrentVersion;
                //return Application.ProductVersion;
                //System.Version version2 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                //return version2;
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
                }
            }
        }

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            
            UserLogin Log1 = new UserLogin();
            if (Log1.RecuperarRegistro(IdUser))
            //if (Log1.RecuperarRegistro(1027))
            //if(Log1.RecuperarRegistro(1014))
            {
                //Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;
                //Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)1;
                Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Administradores;

            }
            else
            {
                //Log1.Id = 1069;
                //Log1.GrupoUsuario.GrupoUsuarioActivo = GrupoUser.GrupoUsuario.Calidad;
            }
            //frmOpcionesMIC_BK frm = new frmOpcionesMIC_BK(Log1);
            //frm.MdiParent = this.MdiParent;

            frmContenedorPrincipal.LlamarEvento(Log1);
            this.Close();
            //if (this.MdiParent != null)
            //    frm.MdiParent = this.MdiParent;
            //frm.Show();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtClave.Focus();
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdLogin_Click(new object(), new EventArgs());
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}