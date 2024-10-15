using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmUbicacionesOP : DevExpress.XtraEditors.XtraForm
    {
        public int idUbicacion;
        public string descripcion;
        public bool enable;
        public Ubicaciones UbicacionActual;
        public frmUbicacionesOP(ComportamientoCRUD pComportamientoActual, int pItem)
        {
            InitializeComponent();
            this.ComportamientoActual = pComportamientoActual;
            UbicacionActual = new Ubicaciones();

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:

                    break;

                case ComportamientoCRUD.Update:
                    if (UbicacionActual.RecuperarRegistro(pItem))
                    {
                        txtUbicaciones.Text = UbicacionActual.descripcion;
                        tggenable.IsOn = UbicacionActual.enable;
                        CargarUbicaciones_especificas(pItem);
                        idUbicacion = pItem;
                    }
                    break;

            }
        }

        public enum ComportamientoCRUD
        {
            Insert = 1,
            Update = 2,

        }
        ComportamientoCRUD ComportamientoActual;

        private void CargarUbicaciones_especificas(int idUbicacion)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("sp_get_mic_ubicaciones_esp_from_id", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pid", idUbicacion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsItems1.ubicacion.Clear();
                adapter.Fill(dsItems1.ubicacion);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }
        private void btnaddUbicacion_Click(object sender, EventArgs e)
        {

            frmAddUbicacion frm = new frmAddUbicacion(frmAddUbicacion.ComportamientoCRUD.Insert, "");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsItems.ubicacionRow row1 = dsItems1.ubicacion.NewubicacionRow();

                var grid = (GridView)grd_data.FocusedView;

                row1.descripcion = frm.valorVarchar;

                //if (frm.AtributoActual.Discontinued)
                //    row1.IsDiscontinued = "Si";
                //else
                //    row1.IsDiscontinued = "No";

                dsItems1.ubicacion.AddubicacionRow(row1);
                dsItems1.AcceptChanges();
            }
        }

        private void cmdRegistrarItem_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(dp.ConnectionStringDEMO);
            bool Guardar = false;
            bool habilitado = true;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_setInsertNewMic_Ubicaciones";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtUbicaciones.Text);
                        cmd.Parameters.AddWithValue("@enable", tggenable.IsOn);



                        int id_header_ubicaciones = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsItems.ubicacionRow row in dsItems1.ubicacion.Rows)
                        {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_setInsertNewMic_UbicacionesEspecificas";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                                cmd.Parameters.AddWithValue("@id_oficina", id_header_ubicaciones);
                                cmd.Parameters.AddWithValue("@enable", habilitado);
                                cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Guardar = true;

                        CajaDialogo.InformationAuto();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ec)
                    {
                        transaction.Rollback();
                        CajaDialogo.Error(ec.Message);
                        Guardar = false;
                    }
                    break;
                case ComportamientoCRUD.Update:
                    if (UbicacionActual.Recuperado)
                    {
                        UbicacionActual.descripcion = txtUbicaciones.Text;
                        UbicacionActual.enable = tggenable.IsOn;
                        descripcion = txtUbicaciones.Text;
                        enable = tggenable.IsOn;


                        conn.Open();
                        transaction = conn.BeginTransaction("Transaction Order");

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "sp_setUpdate_mic_ubicaciones";
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descripcion", txtUbicaciones.Text);
                        cmd.Parameters.AddWithValue("@enable", tggenable.IsOn);
                        cmd.Parameters.AddWithValue("@id", idUbicacion);


                        int id_header_tipoEquipo = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (dsItems.ubicacionRow row in dsItems1.ubicacion.Rows)
                        {
                            if (row.IsidNull())
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_setInsertNewMic_UbicacionesEspecificas";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                                cmd.Parameters.AddWithValue("@id_oficina", idUbicacion);
                                cmd.Parameters.AddWithValue("@enable", habilitado);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.Parameters.Clear();
                                cmd.CommandText = "sp_setUpdate_mic_ubicaciones_esp";
                                cmd.Connection = conn;
                                cmd.Transaction = transaction;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@enable", habilitado);
                                cmd.Parameters.AddWithValue("@descripcion", row.descripcion);
                                cmd.Parameters.AddWithValue("@id", row.id);

                                //cmd.Parameters.AddWithValue("@id", );
                                cmd.ExecuteNonQuery();
                            }



                        }

                        transaction.Commit();
                        Guardar = true;

                        CajaDialogo.InformationAuto();
                        this.DialogResult = DialogResult.OK;
                        this.Close();


                    }
                    break;
            }
        }

        private void frmUbicacionesOP_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = (GridView)grd_data.FocusedView;
            var row = (dsItems.ubicacionRow)gridView.GetFocusedDataRow();

            DataOperations dp = new DataOperations();



            frmAddUbicacion frm = new frmAddUbicacion(frmAddUbicacion.ComportamientoCRUD.Update, row.descripcion);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                row.descripcion = frm.valorVarchar;
                //row.enable = frm.enable;



                //if (frm.AtributoActual.Discontinued)
                //    row.IsDiscontinued = "Si";
                //else
                //    row.IsDiscontinued = "No";

                dsItems1.AcceptChanges();
            }
        }
    }
}