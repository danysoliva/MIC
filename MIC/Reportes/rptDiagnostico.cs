using DevExpress.XtraReports.UI;
using MIC.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace MIC.Reportes
{
    public partial class rptDiagnostico : DevExpress.XtraReports.UI.XtraReport
    {
        string imgURL, path;
        public rptDiagnostico(int pId_Diagnostico)
        {
            InitializeComponent();
            idDiagnos = pId_Diagnostico;
            load_informacion();
            load_informacion_atributos();
            load_archivos_adjuntos();
            
        }
        int idDiagnos;
        DataOperations dp = new DataOperations();
        public void load_informacion()
        {
            string Query = @"mic_report_diagnostico_equipos";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_diagnostico", idDiagnos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.reporteDiagnosticoHeader.Clear();
                da.Fill(dsReportes1.reporteDiagnosticoHeader);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_informacion_atributos()
        {
            string Query = @"mic_report_atributos_equipos_diagnostico_v1";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_diagnostico", idDiagnos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.reporteDiagnosticoAtributos.Clear();
                da.Fill(dsReportes1.reporteDiagnosticoAtributos);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
        public void load_archivos_adjuntos()
        {
            string Query = @"mic_report_archivos_diagnosticos";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_diagnostico", idDiagnos);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.archivos.Clear();
                da.Fill(dsReportes1.archivos);
                cn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
