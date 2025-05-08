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
//using static DevExpress.Data.Mask.Internal.MaskSettings<T>;

namespace MIC.Equipos
{
    public partial class frmHomeDiagnosticos : DevExpress.XtraEditors.XtraForm
    {
        int IdEquipo;
        UserLogin UsuarioLogueado;
        public frmHomeDiagnosticos(UserLogin pUser)
        {
            InitializeComponent();
            CargarDiagnosticos();
            UsuarioLogueado = pUser;
            cmdAgregarNuevo.Enabled = false;
        }

        public frmHomeDiagnosticos(UserLogin pUser, int pIdInt)
        {
            InitializeComponent();
            IdEquipo = pIdInt;
            CargarDiagnosticos();
            UsuarioLogueado = pUser;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarDiagnosticos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command;
                if (IdEquipo > 0)
                {
                    command = new SqlCommand("[sp_get_all_mic_diagnosticos_by_id_equipo]", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_equipo", IdEquipo);
                }
                else
                {
                    command = new SqlCommand("sp_get_all_mic_diagnosticos", connection);
                    command.CommandType = CommandType.StoredProcedure;
                }

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

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            CargarDiagnosticos();
        }

        private void cmdAgregarNuevo_Click(object sender, EventArgs e)
        {
            frmDiagnosticoEquipos frm = new frmDiagnosticoEquipos(frmDiagnosticoEquipos.ComportamientoCRUD.Nuevo, IdEquipo, 0, UsuarioLogueado);
            frm.Show();
        }

        private void cmdAnularDiagnostico_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Esta seguro(a) de cancelar este diagnostico?");
            if (r != DialogResult.Yes)
                return;

            var gridView = (GridView)gridControlDiagnosticos.FocusedView;
            var row = (dsItems.DiagnosticosRow)gridView.GetFocusedDataRow();

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command;

                command = new SqlCommand("[sp_set_anular_diagnostico]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_diagnostico", row.id);
                command.Parameters.AddWithValue("@enable", 0);
                command.Parameters.AddWithValue("@id_usuario_ultima_actualizacion", this.UsuarioLogueado.Id);
                command.Parameters.AddWithValue("@fecha_last_update", DateTime.Now);
                command.ExecuteNonQuery();

                connection.Close();
                CargarDiagnosticos();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }
    }
}