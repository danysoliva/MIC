using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MIC.Clases
{
    public class Atributo
    {
        public Atributo()
        {
           
        }

        #region PROPIEDADES

        public int id { get; set; }

        public string descripcion { get; set; }

        public int tipo_dato { get; set; }

        public string descripcion_tipodato { get; set; }

        public bool enable { get; set; }

        public bool imprimible { get; set; }

        public bool Recuperado { get; set; }


        public string descripcion_tablesID { get; set; }

        public string descripcion_completaTablesID { get; set; }

        public bool enable_tablesID { get; set; }

        public int id_siguiente { get; set; }

        public string codigo { get; set; }


        //public bool deshabilitado { get; set; }

        #endregion

        #region FUNCIONES

        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;

            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
            connection.Open();

            string query = @"dbo.sp_get_mic_atributos_from_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pid", pId);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("id")))
                    id = reader.GetInt32(0);

                if (!reader.IsDBNull(reader.GetOrdinal("id_tipo_dato")))
                    tipo_dato = reader.GetInt32(1);

                if (!reader.IsDBNull(reader.GetOrdinal("TipoDato")))
                    descripcion_tipodato= reader.GetString(2);

                if (!reader.IsDBNull(reader.GetOrdinal("descripcion")))
                    descripcion = reader.GetString(3);

                if (!reader.IsDBNull(reader.GetOrdinal("enable")))
                    enable = reader.GetBoolean(4);

                if (!reader.IsDBNull(reader.GetOrdinal("imprimible")))
                    imprimible = reader.GetBoolean(5);

                Recuperado = true;
            }
            return Recuperado;

        }


        public bool InsertRowAtributos() //Funcion de Insertar
        {
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_setInsertNewMic_Atributos", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id_tipo_dato", tipo_dato);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@enable", enable);
                command.Parameters.AddWithValue("@imprimible", imprimible);

                id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error: " + ex.Message);
                return false;
            }
        }
            public bool UpdateRowAtributos()
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("dbo.sp_setUpdateAtributos", connection);
                    command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id_tipo_dato", tipo_dato);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@enable", enable);
                command.Parameters.AddWithValue("@imprimible", imprimible);
                command.Parameters.AddWithValue("@id", id);
                    id = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    CajaDialogo.Error("Error: " + ex.Message);
                    return false;
                }
            
        }
        #endregion

    }
}
