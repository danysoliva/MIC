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
using MIC.Clases;

namespace MIC.Equipos
{
    public partial class frmCRUDAtributos : Form
    {
        public enum ComportamientoCRUD
        {
            Insert = 1,
            Update = 2
        }

        ComportamientoCRUD ComportamientoActual;

        public Atributo AtributoActual;

        public frmCRUDAtributos()
        {
            InitializeComponent();
        }
        UserLogin UsuarioLogeado;  //Constructor
        public frmCRUDAtributos(UserLogin pUser)
        {
            InitializeComponent();
            CargarTiposDeDatos();
            UsuarioLogeado = pUser;

        }

        public frmCRUDAtributos(ComportamientoCRUD pComportamientoActual, int pAtributoId)
        {
            InitializeComponent();
            this.ComportamientoActual = pComportamientoActual;
            AtributoActual = new Atributo();
            CargarTiposDeDatos();
           

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:
                    break;

                case ComportamientoCRUD.Update:
                    if (AtributoActual.RecuperarRegistro(pAtributoId))
                    {
                        gleAtributos.EditValue = AtributoActual.tipo_dato;
                        txtDescripcion.Text = AtributoActual.descripcion;
                        tggEnable.IsOn = AtributoActual.enable;
                        tggImprimible.IsOn = AtributoActual.imprimible;
                    }
                    break;

            }
        }

        private void frmCRUDAtributos_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

        }
        private void CargarTiposDeDatos()
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection connection = new SqlConnection(dp.ConnectionStringDEMO);
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.sp_get_mic_tipos_datos", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                dsAtributos1.atributos.Clear();
                adapter.Fill(dsAtributos1.atributos);
                connection.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error:" + ex.Message);
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdRegistrar_Atributo_Click(object sender, EventArgs e)
        {
         
            DataOperations dp = new DataOperations();
            if (string.IsNullOrEmpty(gleAtributos.Text))
            {
                CajaDialogo.Error("Debe Seleccionar un Tipo de Dato!");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                CajaDialogo.Error("Debe Ingresar un Nuevo atributo!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Esta seguro de crear este Atributo?");
            if (r != DialogResult.Yes)
                return;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:

                    AtributoActual.tipo_dato = dp.ValidateNumberInt32(gleAtributos.EditValue);
                    AtributoActual.descripcion = txtDescripcion.Text;
                    AtributoActual.enable = tggEnable.IsOn;
                    AtributoActual.imprimible = tggImprimible.IsOn;

                    if (AtributoActual.InsertRowAtributos())
                    {
                        CajaDialogo.InformationAuto();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                case ComportamientoCRUD.Update:
                    if (AtributoActual.Recuperado)
                    {
                        AtributoActual.tipo_dato = dp.ValidateNumberInt32(gleAtributos.EditValue);
                        AtributoActual.descripcion = txtDescripcion.Text;
                        AtributoActual.enable = tggEnable.IsOn;
                        AtributoActual.imprimible = tggImprimible.IsOn;
                        if (AtributoActual.UpdateRowAtributos())
                        {
                            CajaDialogo.InformationAuto();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        CajaDialogo.Error("No se pudo cargar el atributo que desea editar!");
                        return;
                    }
                    break;


            }
        }

        private void cmdCerrar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
