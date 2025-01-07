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
using MIC.Equipos;
using DevExpress.XtraNavBar;

namespace MIC
{
    public partial class frmOpcionesMIC_BK : DevExpress.XtraEditors.XtraForm
    {
        private int childFormNumber = 0;
        UserLogin UsuarioLogeado;
        string ActiveUserCode;
        string ActiveUserName;
        string ActiveUserType;
        string ActiveADUser;
        DataTable UserGroups;

        public frmOpcionesMIC_BK(UserLogin pUser)
        {
            InitializeComponent();
            UsuarioLogeado = pUser;
            int i = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);

            switch (pUser.GrupoUsuario.GrupoUsuarioActivo)
            {
                case GrupoUser.GrupoUsuario.Administradores:
                    navBarControl1.TabIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    navBarItem3.Visible = true;
                    navBarItem4.Visible = true;
                    NavBarItemEquipos.Visible = true;
                    break;
                default:
                    navBarControl1.TabIndex = Convert.ToInt32(pUser.GrupoUsuario.GrupoUsuarioActivo);
                    navBarItem3.Visible = false;
                    navBarItem4.Visible = false;
                    NavBarItemEquipos.Visible = false;
                    navBarGroup2.Visible = true;
                    break;
            }


        }

        private void cmdCrudAtributos_Click(object sender, EventArgs e)
        {
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHOMEAtributos frm = new frmHOMEAtributos(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();

        }

        private void nBitemsCRUDAtribuosEquipos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHomeItems frm = new frmHomeItems(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NavBarItemEquipos_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmFindAtributos frm = new frmFindAtributos(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }

        private void navBarItemAtributos_ItemChanged(object sender, EventArgs e)
        {

        }

        private void navBarItemAtributos_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            
        }

        private void navBarItem3_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmHomeDiagnosticos frm = new frmHomeDiagnosticos(this.UsuarioLogeado);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
