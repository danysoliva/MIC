using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class TipoEquipo
    {
        public TipoEquipo()
          {

          }


        #region PROPIEDADES
        public bool Recuperado { get; set; }
        public string descripcion { get; set; }
        public string descripcion_mostrar { get; set; }
        public int id { get; set; }
        public int id_siguiente { get; set; }
        public bool enable { get; set; }
        public string codigo { get; set; }

        #endregion

        #region FUNCIONES

        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;

            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
            connection.Open();

            string query = @"dbo.sp_get_mic_tablesID_from_id";
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

                if (!reader.IsDBNull(reader.GetOrdinal("tipoEquipo")))
                    descripcion_mostrar = reader.GetString(2);

                if (!reader.IsDBNull(reader.GetOrdinal("enable")))
                    enable = reader.GetBoolean(3);

                if (!reader.IsDBNull(reader.GetOrdinal("id_siguiente")))
                    id_siguiente = reader.GetInt32(4);

                if (!reader.IsDBNull(reader.GetOrdinal("codigo")))
                    codigo = reader.GetString(5);

                Recuperado = true;
            }
            return Recuperado;

        }

        #endregion
    }
}
