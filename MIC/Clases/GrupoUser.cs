using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class GrupoUser
    {
        public enum GrupoUsuario
        {
            
            Administradores = 3,
           
        }

        public GrupoUsuario GrupoUsuarioActivo;

        /// <summary>
        /// Constructor
        /// </summary>
        public GrupoUser()
        {
            GrupoUsuarioActivo = GrupoUsuario.Administradores;
        }

    }
}
