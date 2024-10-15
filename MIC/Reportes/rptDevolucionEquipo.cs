using DevExpress.XtraReports.UI;
using MIC.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace MIC.Reportes
{
    public partial class rptDevolucionEquipo : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDevolucionEquipo(int pId_User)
        {
            InitializeComponent();
           
            id_user = pId_User;

            load_detalle_devolucion();
            load_data();

        }

        public int id_item;
       
        public int id_user;
        DataOperations dp = new DataOperations();

        public void load_data()
        {
            string Query = @"sp_load_user_data";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_user", id_user);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.user.Clear();
                da.Fill(dsReportes1.user);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public void load_detalle_devolucion()
        {
            string Query = @"sp_get_mic_items_devueltos";
            try
            {
                SqlConnection cn = new SqlConnection(dp.ConnectionStringDEMO);
                cn.Open();
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_user", id_user);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dsReportes1.reporteDetalleDevolucion.Clear();
                da.Fill(dsReportes1.reporteDetalleDevolucion);
                cn.Close();


            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
