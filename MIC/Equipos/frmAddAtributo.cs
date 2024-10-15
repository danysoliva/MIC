using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIC.Clases;

namespace MIC.Equipos
{
    public partial class frmAddAtributo : DevExpress.XtraEditors.XtraForm
    {
        public string valorVarchar;
        public bool valorBool;
        public decimal valorNumeric;
        public DateTime valorDate;

        public frmAddAtributo()
        {
            InitializeComponent();
        }
        int id_tipo;
        ComportamientoCRUD ComportamientoActual;

        public Atributo AtributoActual;
        public enum ComportamientoCRUD
        {
            Fecha = 1,
            Varchar = 2,
            Numeric = 3,
            Bit = 4,
        }
        public frmAddAtributo(ComportamientoCRUD pComportamientoActual, int pAtributoId, string pTipoDato, DateTime pValorDate, string pValorVarchar, decimal pValorNumeric, bool pValorBit)
        {
            InitializeComponent();
            //CargarAtributos();
            id_tipo = pAtributoId;
            this.ComportamientoActual = pComportamientoActual;
            AtributoActual = new Atributo();


            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Fecha:
                    dateEdit1.EditValue = pValorDate;
                    lblAtributo.Text = pTipoDato;
                    tggEnable.Visible = false;
                    txtNumeric.Visible = false;
                    txtVarchar.Visible = false;
                    break;

                case ComportamientoCRUD.Varchar:
                    txtVarchar.Text = pValorVarchar;
                    lblAtributo.Text = pTipoDato;
                    dateEdit1.Visible = false;
                    txtNumeric.Visible = false;
                    tggEnable.Visible = false;
                    break;

                case ComportamientoCRUD.Numeric:
                    txtNumeric.Text = Convert.ToString(pValorNumeric);
                    lblAtributo.Text = pTipoDato;

                    dateEdit1.Visible = false;
                    tggEnable.Visible = false;
                    txtVarchar.Visible = false;
                    break;

                case ComportamientoCRUD.Bit:
                    tggEnable.EditValue = pValorBit;
                    lblAtributo.Text = pTipoDato;
                    dateEdit1.Visible = false;
                    txtNumeric.Visible = false;
                    txtVarchar.Visible = false;
                    break;

            }
        }

        private void frmAddAtributo_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarAtributo_Click(object sender, EventArgs e)
        {
            DataOperations dp = new DataOperations();

            //if (string.IsNullOrEmpty(txtDescripcion.Text))
            //{
            //    CajaDialogo.Error("Debe Ingresar un Nuevo atributo!");
            //    return;
            //}

            //DialogResult r = CajaDialogo.Pregunta("Esta seguro de crear este Atributo?");
            //if (r != DialogResult.Yes)
            //    return;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Varchar:
                    if (string.IsNullOrEmpty(txtVarchar.Text))
                    {
                        CajaDialogo.Error("Debe  llenar la caja de texto");
                        return;
                    }

                    valorVarchar = txtVarchar.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                    break;

                case ComportamientoCRUD.Bit:
                    if (tggEnable.IsOn == false)
                    {
                        CajaDialogo.Error("Debe activar el boton de Si o No");
                        return;
                    }
                    valorBool = tggEnable.IsOn;
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case ComportamientoCRUD.Numeric:
                    if (string.IsNullOrEmpty(txtNumeric.Text))
                    {
                        CajaDialogo.Error("Debe  llenar la caja de texto");
                        return;
                    }
                    valorNumeric = Convert.ToDecimal(txtNumeric.Text);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case ComportamientoCRUD.Fecha:
                    if (dateEdit1.Text == "")
                    {
                        CajaDialogo.Error("Debe elegir una fecha");
                    }

                    valorDate = dateEdit1.DateTime;
                  
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;

            }
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void numericData(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeric.Text))
            {
                CajaDialogo.Error("Debe  llenar la caja de texto");
                return;
            }
            valorNumeric = Convert.ToDecimal(txtNumeric.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void varcharData(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVarchar.Text))
            {
                CajaDialogo.Error("Debe  llenar la caja de texto");
                return;
            }

            valorVarchar = txtVarchar.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateData(object sender, EventArgs e)
        {
            if (dateEdit1.Text == "")
            {
                CajaDialogo.Error("Debe elegir una fecha");
            }

            valorDate = dateEdit1.DateTime;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bitData(object sender, EventArgs e)
        {
            if (tggEnable.IsOn == false)
            {
                CajaDialogo.Error("Debe activar el boton de Si o No");
                return;
            }
            valorBool = tggEnable.IsOn;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void txtVarchar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtVarchar_KeyDown(object sender, KeyEventArgs e)//Al presionar enter guarda los datos en el DataSet
        {
            if (e.KeyCode == Keys.Enter)
            {
                varcharData(this, new EventArgs());
            }
        }

        private void txtNumeric_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                numericData(this, new EventArgs());
            }
        }

        private void dateEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dateData(this, new EventArgs());
            }
        }

        private void tggEnable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bitData(this, new EventArgs());
            }
        }
    }
}