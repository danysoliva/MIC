using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Clases
{
 
        public class DataOperations
        {

            #region Connection Credentials

            public string ConnectionStringDEMO = @"Server=" + Globals.CONN_Server + @";
                                                   Database=" + Globals.CONN_ActiveDB + @";
                                                   User Id=" + Globals.CONN_DB_User + @";
                                                   Password=" + Globals.CONN_DB_Pass + ";";


          //internal string ConnectionStringCostos = @"Server=" + Globals.CTS_ServerAddress + @";
          //                                         Database=" + Globals.CTS_ActiveDB + @";
          //                                         user Id=" + Globals.CTS_DB_User + @";
          //                                         Password=" + Globals.CTS_DB_Pass + ";";


        public string ConnectionStringCostos = @"Server=" + Globals.CTS_ServerAddress + @";
                                                   Database=" + Globals.CTS_ActiveDB + @";
                                                   User Id=" + Globals.CTS_DB_User + @";
                                                   Password=" + Globals.CTS_DB_Pass + ";";

        public string FTP_APMS_IT { get; internal set; }
        internal string FTP_MIC = @"ftp://10.50.11.32/MIC/ADJUNTOS/";
        internal string FTP_MIC_DIAG = @"ftp://10.50.11.32/MIC/DIAGNOSTICOS/";
        #endregion

        public decimal ValidateNumberDecimal(object val)
            {
                decimal valor = 0;
                try
                {
                    valor = Convert.ToDecimal(val);
                }
                catch { }
                return valor;
            }

            public int ValidateNumberInt32(object val)
            {
                int valor = 0;
                try
                {
                    valor = Convert.ToInt32(val);
                    //valor = (int)val;
                }
                catch
                {
                    string vals;
                    try
                    {
                        vals = val.ToString();
                        decimal valDecimal = Convert.ToDecimal(val);
                        valor = Decimal.ToInt32(valDecimal);
                    }
                    catch
                    {
                        valor = 0;
                    }
                }
                return valor;
            }



        }
    }

