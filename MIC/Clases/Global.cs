using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
    public class Globals
    {
        //MIC(Items)
        public static string CONN_Server = "AQFSVR010\\AQFSVR010";
        public static string CONN_DB_User = "losa_user_db";
        public static string CONN_DB_Pass = "AquaF33dHN2014";
        public static string CONN_ActiveDB = "MIC";

        //internal string ConnectionStringDEMO = @"Server=" + Globals.CONN_Server + @";
        //                                         Database=" + Globals.CONN_ActiveDB + @";
        //                                         User Id=" + Globals.CONN_DB_User + @";
        //                                         Password=" + Globals.CONN_DB_Pass + ";";


        //ACS(Costos)
        public static string CTS_ServerAddress = "AQFSVR010\\AQFSVR010";
        public static string CTS_ActiveDB = "ACS";
        public static string CTS_DB_User = "losa_user_db";
        public static string CTS_DB_Pass = "AquaF33dHN2014";


    }
}
