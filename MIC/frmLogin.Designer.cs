
namespace MIC
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.cmdLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(56, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(344, 36);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Bienvenido";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 24);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 168);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 24);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.EditValue = "";
            this.txtClave.Location = new System.Drawing.Point(123, 162);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtClave.Properties.Appearance.Options.UseFont = true;
            this.txtClave.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtClave.Properties.ContextImageOptions.Image")));
            this.txtClave.Properties.UseSystemPasswordChar = true;
            this.txtClave.Size = new System.Drawing.Size(222, 36);
            this.txtClave.TabIndex = 14;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(123, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtUsuario.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtUsuario.Properties.ContextImageOptions.Image")));
            this.txtUsuario.Size = new System.Drawing.Size(222, 36);
            this.txtUsuario.TabIndex = 13;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdLogin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Appearance.Options.UseBackColor = true;
            this.cmdLogin.Appearance.Options.UseBorderColor = true;
            this.cmdLogin.Appearance.Options.UseFont = true;
            this.cmdLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdLogin.Location = new System.Drawing.Point(48, 232);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(199, 59);
            this.cmdLogin.TabIndex = 18;
            this.cmdLogin.Text = "Ingresar";
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.BackColor = System.Drawing.Color.LightPink;
            this.cmdCerrar.Appearance.BorderColor = System.Drawing.Color.LightPink;
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseBackColor = true;
            this.cmdCerrar.Appearance.Options.UseBorderColor = true;
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCerrar.Location = new System.Drawing.Point(253, 232);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(199, 59);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdAdmin
            // 
            this.cmdAdmin.Appearance.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmdAdmin.Appearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.cmdAdmin.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdmin.Appearance.Options.UseBackColor = true;
            this.cmdAdmin.Appearance.Options.UseBorderColor = true;
            this.cmdAdmin.Appearance.Options.UseFont = true;
            this.cmdAdmin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAdmin.Location = new System.Drawing.Point(146, 297);
            this.cmdAdmin.Name = "cmdAdmin";
            this.cmdAdmin.Size = new System.Drawing.Size(199, 59);
            this.cmdAdmin.TabIndex = 20;
            this.cmdAdmin.Text = "Administrador";
            this.cmdAdmin.Click += new System.EventHandler(this.cmdAdmin_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(366, 102);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(113, 96);
            this.pictureEdit1.TabIndex = 21;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 373);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.cmdAdmin);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.SimpleButton cmdLogin;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdAdmin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}