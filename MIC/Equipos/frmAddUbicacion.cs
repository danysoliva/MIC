using DevExpress.XtraEditors;
using MIC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC.Equipos
{
    public partial class frmAddUbicacion : DevExpress.XtraEditors.XtraForm
    {
        
        
        public frmAddUbicacion(ComportamientoCRUD pComportamientoActual, string pDescripcion)
        {
            InitializeComponent();
            this.ComportamientoActual = pComportamientoActual;

            switch (ComportamientoActual)
            {
                case ComportamientoCRUD.Insert:

                    break;

                case ComportamientoCRUD.Update:
                    
                        txtUbicaciones.Text = pDescripcion;
                        
                    break;

            }

        }



        public enum ComportamientoCRUD
        {
            Insert = 1,
            Update = 2,

        }
        ComportamientoCRUD ComportamientoActual;

        public string valorVarchar;
        
        private void frmAddUbicacion_Load(object sender, EventArgs e)
        {

        }

        private void cmdRegistrarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUbicaciones.Text))
            {
                CajaDialogo.Error("Debe  llenar la caja de texto");
                return;
            }

            valorVarchar = txtUbicaciones.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}