using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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

namespace MIC.Equipos
{
    public partial class frmHomeDiagnosticos : DevExpress.XtraEditors.XtraForm
    {
        public frmHomeDiagnosticos(UserLogin pUser)
        {
            InitializeComponent();
            CargarDiagnosticos();
            UsuarioLogueado = pUser;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        UserLogin UsuarioLogueado;
        private void CargarDiagnosticos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_all_mic_diagnosticos", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.Diagnosticos.Clear();
                adapter.Fill(dsItems1.Diagnosticos);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void btnEditar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var gridView = (GridView)gridControlDiagnosticos.FocusedView;
            var row = (dsItems.DiagnosticosRow)gridView.GetFocusedDataRow();

            frmDiagnosticoEquipos frm = new frmDiagnosticoEquipos(frmDiagnosticoEquipos.ComportamientoCRUD.Ver,row.idEquipo,row.id,UsuarioLogueado);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)gridControlDiagnosticos.FocusedView;
            var row = (dsItems.DiagnosticosRow)gridView.GetFocusedDataRow();

            MIC.Reportes.rptDiagnostico rpt = new Reportes.rptDiagnostico(row.id);
            rpt.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            ReportPrintTool printReport = new ReportPrintTool(rpt);
            printReport.ShowPreview();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}