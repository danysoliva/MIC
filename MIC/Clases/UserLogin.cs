using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class UserLogin
    {
        public GrupoUser GrupoUsuario;
        string username;
        string password;
        bool recuperado;
        private int id;
        private int idGrupo;
        private string nombreUser;
        private string ADuser;
        private string pass;
        private int idnivel;
        private string tipo;

        //Constructor
        //public UserLogin()
        //{
        //    username = "ever.erazo";
        //    password = "Kiasoul2015.";
        //}
        public UserLogin()
        {
            GrupoUsuario = new GrupoUser();
        }
        #region PROPIEDADES


        public bool Recuperado { get => recuperado; set => recuperado = value; }
        public int Id { get => id; set => id = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NombreUser { get => nombreUser; set => nombreUser = value; }
        public string ADuser1 { get => ADuser; set => ADuser = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Idnivel { get => idnivel; set => idnivel = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string HostNameConnected { get; set; }
        public bool NotificacionesActivas { get; set; }
        public string UserName
        {
            get => username; set => username = value;

        }
        bool vSuperUser;
        public bool IsSuperUser
        {
            get { return vSuperUser; }
            set { vSuperUser = value; }
        }

        public string Password
        {
            get => password; set => password = value;
        }
        //public object GrupoUsuario { get; internal set; }



        #endregion

        //public bool RecuperarRegistro()
        //{
        //    recuperado = true;
        //    return Recuperado;
        //}
        public bool RecuperarRegistro(int pId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                string sql = @"SELECT id, 
                                       nombre, 
                                        ADUser,
	                                   id_grupo_losa,
                                       tipo,
                                       super_user,
                                       [notificaciones_activas]
                                FROM [ACS].dbo.conf_usuarios 
                                where id =" + pId;
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    ADuser = dr.GetString(2);
                    idGrupo = dr.GetInt32(3);
                    Tipo = dr.GetString(4);
                    IsSuperUser = dr.GetBoolean(5);
                    NotificacionesActivas = dr.GetBoolean(6);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }

        public bool RecuperarRegistroFromUser(string pUser)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringCostos);
                con.Open();
                string sql = @"SELECT top 1 id, 
                                       nombre, 
	                                   id_grupo_losa,
                                       ADUser,
                                       super_user,
                                       [notificaciones_activas]
                                FROM [ACS].dbo.conf_usuarios 
                                where [ADUser] ='" + pUser + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    nombreUser = dr.GetString(1);
                    idGrupo = dr.GetInt32(2);
                    ADuser = dr.GetString(3);
                    IsSuperUser = dr.GetBoolean(4);
                    NotificacionesActivas = dr.GetBoolean(5);
                    recuperado = true;
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ec)
            {
                recuperado = false;
                CajaDialogo.Error(ec.Message);
            }
            return Recuperado;
        }
    }
}
