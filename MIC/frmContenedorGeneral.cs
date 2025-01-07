using MIC.Clases;
using MIC.Equipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIC
{
    public partial class frmContenedorGeneral : Form
    {
        private int childFormNumber = 0;
        UserLogin UsuarioLogeado;
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string ActiveADUser;
        DataTable UserGroups;

        public frmContenedorGeneral()
        {
            InitializeComponent();
            frmLogin loginFRM = new frmLogin(this);
            loginFRM.MdiParent = this;
            loginFRM.Show();
        }

        

        // Método público para invocar el evento
        public void LlamarEvento(UserLogin pUsuarioLogeado)
        {
            // Invoca el manejador del evento directamente
            this.UsuarioLogeado = pUsuarioLogeado;
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Equipos
            if(UsuarioLogeado == null)
            {
                CajaDialogo.Error("Es necesario iniciar sesión!");
                return; 
            }

            frmFindAtributos frm = new frmFindAtributos(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UsuarioLogeado = null;
            frmLogin loginFRM = new frmLogin(this);
            loginFRM.MdiParent = this;
            loginFRM.StartPosition = FormStartPosition.CenterParent;
            loginFRM.WindowState = FormWindowState.Normal;
            loginFRM.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void diagnosticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Diagnosticos
            if (UsuarioLogeado == null)
            {
                CajaDialogo.Error("Es necesario iniciar sesión!");
                return;
            }

            frmHomeDiagnosticos frm = new frmHomeDiagnosticos(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
    }
}
