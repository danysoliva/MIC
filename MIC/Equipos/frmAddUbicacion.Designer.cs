
namespace MIC.Equipos
{
    partial class frmAddUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUbicacion));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUbicaciones = new DevExpress.XtraEditors.TextEdit();
            this.cmdRegistrarItem = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbicaciones.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 21);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Ubicacion:";
            // 
            // txtUbicaciones
            // 
            this.txtUbicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUbicaciones.Location = new System.Drawing.Point(100, 46);
            this.txtUbicaciones.Name = "txtUbicaciones";
            this.txtUbicaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicaciones.Properties.Appearance.Options.UseFont = true;
            this.txtUbicaciones.Properties.MaxLength = 70;
            this.txtUbicaciones.Size = new System.Drawing.Size(278, 28);
            this.txtUbicaciones.TabIndex = 18;
            // 
            // cmdRegistrarItem
            // 
            this.cmdRegistrarItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarItem.ImageOptions.Image")));
            this.cmdRegistrarItem.Location = new System.Drawing.Point(100, 131);
            this.cmdRegistrarItem.Name = "cmdRegistrarItem";
            this.cmdRegistrarItem.Size = new System.Drawing.Size(124, 34);
            this.cmdRegistrarItem.TabIndex = 21;
            this.cmdRegistrarItem.Text = "AGREGAR";
            this.cmdRegistrarItem.Click += new System.EventHandler(this.cmdRegistrarItem_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(255, 131);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(123, 34);
            this.cmdCerrar.TabIndex = 22;
            this.cmdCerrar.Text = "CANCELAR";
            // 
            // frmAddUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 190);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRegistrarItem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUbicaciones);
            this.Name = "frmAddUbicacion";
            this.Text = "Agregar Ubicación";
            this.Load += new System.EventHandler(this.frmAddUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUbicaciones.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUbicaciones;
        private DevExpress.XtraEditors.SimpleButton cmdRegistrarItem;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}