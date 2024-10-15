using DevExpress.XtraReports.UI;
using MIC.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace MIC.Reportes
{
    public partial class rptEntregaCelulares : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEntregaCelulares(int pId_Item)
        {
            InitializeComponent();
            id_item = pId_Item;
            load_informacion();


        }

        public int id_item, id_user;

        DataOperations dp = new DataOperations();

        public void load_informacion()
        {
            string Query = @"mic_reporte_asignacion_celular";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_item", id_item);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.reporteCelular.Clear();
                da.Fill(dsReportes1.reporteCelular);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

    }
}
