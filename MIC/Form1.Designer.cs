namespace MIC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavBarItemEquipos = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Atributos";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.navBarGroup1.Appearance.BorderColor = System.Drawing.Color.White;
            this.navBarGroup1.Appearance.Options.UseBackColor = true;
            this.navBarGroup1.Appearance.Options.UseBorderColor = true;
            this.navBarGroup1.Caption = "MENU PRINCIPAL";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.NavBarItemEquipos,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 210;
            this.navBarControl1.Size = new System.Drawing.Size(210, 627);
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "REPORTES";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.AppearanceBackground.BackColor = System.Drawing.Color.SaddleBrown;
            this.navBarGroup2.AppearanceBackground.Options.UseBackColor = true;
            this.navBarGroup2.AppearancePressed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.navBarGroup2.AppearancePressed.BorderColor = System.Drawing.Color.SkyBlue;
            this.navBarGroup2.AppearancePressed.Options.UseBackColor = true;
            this.navBarGroup2.AppearancePressed.Options.UseBorderColor = true;
            this.navBarGroup2.Caption = "MENU PRINCIPAL";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NavBarItemEquipos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // NavBarItemEquipos
            // 
            this.NavBarItemEquipos.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.NavBarItemEquipos.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.NavBarItemEquipos.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBarItemEquipos.Appearance.Options.UseBackColor = true;
            this.NavBarItemEquipos.Appearance.Options.UseBorderColor = true;
            this.NavBarItemEquipos.Appearance.Options.UseFont = true;
            this.NavBarItemEquipos.AppearanceHotTracked.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBarItemEquipos.AppearanceHotTracked.Options.UseFont = true;
            this.NavBarItemEquipos.AppearancePressed.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBarItemEquipos.AppearancePressed.Options.UseFont = true;
            this.NavBarItemEquipos.Caption = "EQUIPOS";
            this.NavBarItemEquipos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NavBarItemEquipos.ImageOptions.SvgImage")));
            this.NavBarItemEquipos.Name = "NavBarItemEquipos";
            this.NavBarItemEquipos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarItemEquipos_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem3.Appearance.Options.UseFont = true;
            this.navBarItem3.AppearanceHotTracked.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem3.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItem3.AppearancePressed.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem3.AppearancePressed.Options.UseFont = true;
            this.navBarItem3.Caption = "DIAGNOSTICOS";
            this.navBarItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem3.ImageOptions.SvgImage")));
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem4.Appearance.Options.UseFont = true;
            this.navBarItem4.AppearanceHotTracked.BackColor = System.Drawing.Color.LightSkyBlue;
            this.navBarItem4.AppearanceHotTracked.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.navBarItem4.AppearanceHotTracked.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem4.AppearanceHotTracked.Options.UseBackColor = true;
            this.navBarItem4.AppearanceHotTracked.Options.UseBorderColor = true;
            this.navBarItem4.AppearanceHotTracked.Options.UseFont = true;
            this.navBarItem4.AppearancePressed.BackColor = System.Drawing.Color.SlateGray;
            this.navBarItem4.AppearancePressed.BorderColor = System.Drawing.Color.SlateGray;
            this.navBarItem4.AppearancePressed.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem4.AppearancePressed.Options.UseBackColor = true;
            this.navBarItem4.AppearancePressed.Options.UseBorderColor = true;
            this.navBarItem4.AppearancePressed.Options.UseFont = true;
            this.navBarItem4.Caption = "REPORTES";
            this.navBarItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem4.ImageOptions.SvgImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "HOME";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::MIC.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(1186, 627);
            this.Controls.Add(this.navBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MIC-Formularo Principal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem NavBarItemEquipos;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
    }
}

