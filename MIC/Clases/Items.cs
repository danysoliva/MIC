using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class Items
    {
        public Items()
      {

      }
        #region PROPIEDADES

        public int id { get; set; }

        public string items_code { get; set; }

        public string nombre { get; set; }

        public int id_tipo_equipo { get; set; }

        public bool enable { get; set; }

        public string marca { get; set; }

        public string comentario { get; set; }

        public bool bit_asignable { get; set; }

        public DateTime created { get; set; }

        public int id_estado { get; set; }

        public string descripcion_mostrar_tables { get; set; }
        public string estado { get; set; }

        public bool multiusuario { get; set; }



        public bool Recuperado { get; set; }


        #endregion

        #region FUNCIONES

        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;

            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
            connection.Open();

            string query = @"dbo.sp_get_mic_items_from_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pid", pId);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("id")))
                    id = reader.GetInt32(0);

                if (!reader.IsDBNull(reader.GetOrdinal("items_code")))
                    items_code = reader.GetString(1);

                if (!reader.IsDBNull(reader.GetOrdinal("nombre")))
                    nombre = reader.GetString(2);

                if (!reader.IsDBNull(reader.GetOrdinal("id_tipo_equipo")))
                    id_tipo_equipo = reader.GetInt32(3);

                if (!reader.IsDBNull(reader.GetOrdinal("descripcion_mostrar_tables")))
                    descripcion_mostrar_tables = reader.GetString(4);

                if (!reader.IsDBNull(reader.GetOrdinal("enable")))
                    enable = reader.GetBoolean(5);

                if (!reader.IsDBNull(reader.GetOrdinal("marca")))
                    marca = reader.GetString(6);

                if (!reader.IsDBNull(reader.GetOrdinal("comentario")))
                    comentario = reader.GetString(7);

                if (!reader.IsDBNull(reader.GetOrdinal("bit_asignable")))
                    bit_asignable= reader.GetBoolean(8);

                if (!reader.IsDBNull(reader.GetOrdinal("created")))
                    created = reader.GetDateTime(9);

                if (!reader.IsDBNull(reader.GetOrdinal("id_estado")))
                    id_estado = reader.GetInt32(10);

                if(!reader.IsDBNull(reader.GetOrdinal("estado")))
                    estado = reader.GetString(11);

                if (!reader.IsDBNull(reader.GetOrdinal("multiusuario")))
                    multiusuario = reader.GetBoolean(12);

                Recuperado = true;
            }
            return Recuperado;
        }
        public bool InsertRowItems() //Funcion de Insertar
        {
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_setInsertNewMic_Items", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@items_code",items_code);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@id_tipo_equipo", id_tipo_equipo);
                command.Parameters.AddWithValue("@enable", enable);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@comentario",comentario);
                command.Parameters.AddWithValue("@bit_asignable",bit_asignable);
                command.Parameters.AddWithValue("@created",created);
                command.Parameters.AddWithValue("@id_estado", id_estado);

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
        public bool UpdateRowItems()
        {
            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_setUpdateItems", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@items_code", items_code);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@id_tipo_equipo", id_tipo_equipo);
                command.Parameters.AddWithValue("@enable", enable);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@comentario", comentario);
                command.Parameters.AddWithValue("@bit_asignable", bit_asignable);
                command.Parameters.AddWithValue("@created", created);
                command.Parameters.AddWithValue("@id_estado", id_estado);
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
