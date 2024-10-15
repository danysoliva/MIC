using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class Diagnosticos
    {
        public Diagnosticos()
         {

         }

        #region PROPIEDADES

        public int id { get; set; }


        public int idEquipo { get; set; }

        public string equipo { get; set; }

        public int idUsuario { get; set; }

        public string usuario { get; set; }

        public string tipoEquipo { get; set; }

        public string relevancia { get; set; }

        public string ubicacionGeneral{ get; set; }

        public string ubicacionEspecifica { get; set; }

        public string tecnicoIT { get; set; }

        public DateTime fecha { get; set; }

        public string falla { get; set; }
        public string diagnostico { get; set; }

        #endregion


        public bool Recuperado { get; set; }

        #region FUNCIONES
        public bool RecuperarRegistro(int pId)
        {
            Recuperado = false;

            DataOperations dp = new DataOperations();
            SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
            connection.Open();

            string query = @"dbo.sp_get_mic_diagnosticos_by_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pid", pId);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("id")))
                    id = reader.GetInt32(0);

                if (!reader.IsDBNull(reader.GetOrdinal("idEquipo")))
                    idEquipo = reader.GetInt32(1);

                if (!reader.IsDBNull(reader.GetOrdinal("equipo")))
                    equipo = reader.GetString(2);

                if (!reader.IsDBNull(reader.GetOrdinal("idUsuario")))
                    idUsuario = reader.GetInt32(3);

                if (!reader.IsDBNull(reader.GetOrdinal("usuario")))
                    usuario= reader.GetString(4);

                if (!reader.IsDBNull(reader.GetOrdinal("tipoEquipo")))
                    tipoEquipo = reader.GetString(5);

                if (!reader.IsDBNull(reader.GetOrdinal("relevancia")))
                    relevancia = reader.GetString(6);

                if (!reader.IsDBNull(reader.GetOrdinal("ubicacionGeneral")))
                    ubicacionGeneral = reader.GetString(7);

                if (!reader.IsDBNull(reader.GetOrdinal("ubicacionEspecifica")))
                    ubicacionEspecifica = reader.GetString(8);

                if (!reader.IsDBNull(reader.GetOrdinal("falla")))
                    falla = reader.GetString(9);

                if (!reader.IsDBNull(reader.GetOrdinal("diagnostico")))
                    diagnostico = reader.GetString(10);

                if (!reader.IsDBNull(reader.GetOrdinal("tecnicoIT")))
                    tecnicoIT = reader.GetString(11);

                if (!reader.IsDBNull(reader.GetOrdinal("fecha")))
                    fecha = reader.GetDateTime(12);

                Recuperado = true;
            }
            return Recuperado;
        }
        #endregion
    }
}
