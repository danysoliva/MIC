using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC.Clases
{
   public  class tables_id
    {
        public int id;
        public string descripcion;
        public bool enable;
        public int id_siguiente;
        public DateTime fecha_registro;
        public string codigo;

        public tables_id()
        {

        }

        public bool Recuperar_registros(int p_id)
        {
            bool result;

            return result = false;
        }

        public string generar_id_siguiente(int p_id_secuencia)
        {
            string codigo = "";

            try
            {
                string conection = "Server=13LBQT2;Database=MIC;User Id=sa;Password=Fabiola1503";
                SqlConnection con = new SqlConnection(conection);

                con.Open();

                SqlCommand cmdIdSig = new SqlCommand("", con);
                cmdIdSig.CommandText = @"SELECT [id_siguiente]
                                          FROM [MIC].[dbo].[mic_tablas_id]
                                          where id = @parametro";
                cmdIdSig.Parameters.AddWithValue("@parametro", p_id_secuencia);
                SqlDataReader dr = cmdIdSig.ExecuteReader();
                int id_sig = 0;
                if (dr.Read())
                    id_sig = dr.GetInt32(0);

                dr.Close();


                SqlCommand cmdCodigo = new SqlCommand("", con);
                cmdCodigo.CommandText = @"SELECT [codigo]
                                          FROM [MIC].[dbo].[mic_tablas_id]
                                          where id = @parametro";
                cmdCodigo.Parameters.AddWithValue("@parametro", p_id_secuencia);
                SqlDataReader drCodigo = cmdCodigo.ExecuteReader();
                string Codigo = "";
                if (drCodigo.Read())
                    Codigo = drCodigo.GetString(0);

                drCodigo.Close();

                codigo = Codigo + id_sig.ToString();
                //if (con. State== System.Data.ConnectionState.Open)
                //    MessageBox.Show("conexion exitosa local");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return codigo;

        }

    }

}

