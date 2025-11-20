using DevExpress.CodeParser;
using DevExpress.Pdf.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using MIC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC.Reportes
{
    public partial class mainReportes : DevExpress.XtraEditors.XtraForm
    {
        public mainReportes()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            try
            {
                DataOperations dp = new DataOperations();
                using (SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO))
                using (SqlCommand cmd = new SqlCommand("sp_get_reports", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adat = new SqlDataAdapter(cmd))
                    {
                        dsReportes1.report_list.Clear();
                        adat.Fill(dsReportes1.report_list);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                CajaDialogo.Error($"Error SQL: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                CajaDialogo.Error($"Error general: {ex.Message}");
            }
        }

        private void grdluRpts_EditValueChanged(object sender, EventArgs e)
        {
            switch (grdluRpts.EditValue)
            {
                case 1:

                    break;
                default:
                    break;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (grdluRpts.EditValue)
            {
                case 1:
                    query = @"sp_rpt_computadoras_estados";
                    break;

                default:
                    CajaDialogo.Error("Seleccione un reporte válido.");
                    break;
            }

            DataOperations dp = new DataOperations();
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    switch (grdluRpts.EditValue)
                    {
                        case 1:
                            
                            break;

                        case 2:
                            
                            break;
                    }


                    DataTable tabla = new DataTable();
                    using (SqlDataAdapter adat = new SqlDataAdapter(cmd))
                    {
                        adat.Fill(tabla);
                        grdReportes.DataSource = tabla;
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grdReportes.ExportToXlsx(dialog.FileName);
            }
        }
    }
}