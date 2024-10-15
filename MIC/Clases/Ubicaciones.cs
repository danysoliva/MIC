using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class Ubicaciones
    {
        #region PROPIEDADES

        public int id { get; set; }
        public bool Recuperado { get; set; }
        public string descripcion { get; set; }

        public bool enable { get; set; }
        #endregion


        #region FUNCIONES
        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;

            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
            connection.Open();

            string query = @"sp_get_mic_ubicaciones_from_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pid", pId);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("id")))
                    id = reader.GetInt32(0);

                if (!reader.IsDBNull(reader.GetOrdinal("descripcion")))
                    descripcion = reader.GetString(1);

                if (!reader.IsDBNull(reader.GetOrdinal("enable")))
                    enable = reader.GetBoolean(2);

                Recuperado = true;
            }
            return Recuperado;

        }
        public bool InsertRowUbicaciones()//funcion de insertar
        {
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_setInsertNewMic_Ubicaciones", connection);
                command.CommandType = CommandType.StoredProcedure;

               
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@enable", enable);
               

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
