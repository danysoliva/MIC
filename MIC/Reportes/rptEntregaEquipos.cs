using DevExpress.XtraReports.UI;
using MIC.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace MIC.Reportes
{
    public partial class rptEntregaEquipos : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEntregaEquipos(int pId_Item, string pUser,int pId_User)
        {
            InitializeComponent();
          
            lbluser.Text = pUser;
            id_user = pId_User;
            id_item = pId_Item;
            CargarConf();
            load_informacion();
            if (id_empresa == 1)
            {
                xrLabel2.Text = "Intervienen en la suscripción de la presente acta por una parte Aquafeed S.A. de C.V, representada por su Gerente General, Erik Flores, por otra el colaborador Danys Oliva Coordinador de IT Aquafeed, usuario del equipo que se entrega.";
                xrLabel3.Text = @"1.-El equipo de cómputo, los componentes que se entregan, y la información son de propiedad exclusiva de Aquafeed.

2.- El usuario receptor del equipo es responsable de su cuidado, limpieza y de su correcta utilización.  Es igualmente responsable de la información que se procesa en el equipo.  En caso de daño, robo o pérdida del equipo, la empresa investigará las circunstancias de cada caso y si hubiera negligencia, descuido o mala intención, el empleado asumirá la reparación o reposición del equipo.

3.- El usuario se compromete a respetar los estándares definidos por la empresa y todo lo que manifiesta nuestra política de seguridad de la información.

4.- Está terminantemente prohibido utilizar en los equipos movil de la empresa cualquier tipo de software no autorizado, todo reclamo legal, producto de una instalación no autorizada de cualquier tipo de software, será asumido por el responsable del equipo.

5.- Las instalaciones de software aprobado por la empresa, deberán ser solicitadas al Departamento de Aquafeed IT.

6.- El usuario deberá reportar inmediatamente al Departamento de Sistemas, cualquier anormalidad que detecte en el funcionamiento del equipo / software.  El usuario no está autorizado a abrir, manipular ni extraer las partes y piezas de los equipos. 

7.- Las claves que permiten el acceso a la red o a otros software o servicios de la compañía, son personales, confidenciales y cada usuario deberá cambiarlas mínimo cada tres meses, cuando el personal de sistemas se lo solicite, o cuando el sistema automáticamente se lo requiera.La clave permite identificar al usuario que realizó una determinada operación en el sistema.  Cuando una persona sale de vacaciones no podrá dejar la clave a la persona que queda a cargo.

8.- El usuario deberá almacenar toda la información que guarde / descargue del correo, considerando que ésta es necesaria para el desempeño de sus funciones, en la carpeta Mis Documentos, para evitar pérdidas de información.

9.- El departamento de informática no da garantías de respaldo de información personal o trabajos que no sean de la empresa.

10.- Todo dispositivo de almacenamiento proveniente de personas externas a la compañía, deberá ser revisado antes por el antivirus.

11.- No se deben utilizar dispositivos de almacenamiento en equipos de la compañía luego de utilizarlos en otros equipos, sin que hayan sido revisados previamente por el antivirus.  

12.- No se debe copiar información de Aquafeed en equipos de cómputo que no son propiedad de la empresa, excepto que se cuente con la autorización del gerente de Área y el jefe de sistemas.";
                     lblPromix.Visible = false;
                        xrLine2.Visible = false;

            }
            else
            {
                xrLabel2.Text = "Intervienen en la suscripción de la presente acta por una parte Promix S.A. de C.V, representada por Anibal Luciche, por otra el colaborador Danys Oliva Coordinador de IT Aquafeed, usuario del equipo que se entrega.";
                xrLabel3.Text = @"1.-El equipo de cómputo, los componentes que se entregan, y la información son de propiedad exclusiva de Promix.

2.-El usuario receptor del equipo es responsable de su cuidado, limpieza y de su correcta utilización.  Es igualmente responsable de la información que se procesa en el equipo.  En caso de daño, robo o pérdida del equipo, la empresa investigará las circunstancias de cada caso y si hubiera negligencia, descuido o mala 	intención, el empleado asumirá la reparación o reposición del equipo.
                
 3.-El usuario se compromete a respetar los estándares definidos por la empresa y todo lo que manifiesta nuestra política de seguridad de la información.

 4.-Está terminantemente prohibido utilizar en los equipos movil de la empresa cualquier tipo de software no autorizado, todo reclamo legal, producto de una instalación no autorizada de cualquier tipo de software, será asumido por el responsable del equipo.

 5.-Las instalaciones de software aprobado por la empresa, deberán ser solicitadas al Departamento de Skretting IT.

 6.-El usuario deberá reportar inmediatamente al Departamento de Sistemas, cualquier anormalidad que detecte en el funcionamiento del equipo / software.  El usuario no está autorizado a abrir, manipular ni extraer las partes y piezas de los equipos. 

 7.-El departamento de Sistemas no da garantías de respaldo de información personal o trabajos que no sean de la empresa.

 8.- El dispositivo movil tiene seguro. En caso de daño, el deducible del seguro sera pagado por el empleado."; 
                    lblPromix.Text = "Anibal Luciche";
            }


        }

        public int id_item;
        public int id_empresa;
        public int id_user;
        DataOperations dp = new DataOperations();

        public void load_informacion()
        {
            string Query = @"mic_report_atributos_equipos";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_item", id_item);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.reportes.Clear();
                da.Fill(dsReportes1.reportes);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void CargarConf()
        {
            string Query = @"sp_obtener_Empresa_usuario";
            SqlConnection cn = new SqlConnection(dp.ConnectionStringCostos);
            cn.Open();
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_user", id_user);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id_empresa = !dr.IsDBNull(0) ? dr.GetInt32(0) : 1;

            }
            cn.Close();
            dr.Close();
           
        }
    }
}
