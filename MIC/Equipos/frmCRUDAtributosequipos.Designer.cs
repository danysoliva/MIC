namespace MIC.Equipos
{
    partial class frmCRUDAtributosequipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDAtributosequipos));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdAtributo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorFecha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorNumerico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorVarchar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tggBitAsignable = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmdRegistrar_Atributo_Equipo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAtributo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorNumerico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVarchar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggBitAsignable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "GESTION DE ATRIBUTOS DE EQUIPO";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtIdAtributo
            // 
            this.txtIdAtributo.Location = new System.Drawing.Point(26, 74);
            this.txtIdAtributo.Name = "txtIdAtributo";
            this.txtIdAtributo.Size = new System.Drawing.Size(100, 20);
            this.txtIdAtributo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Identificador de atributo";
            // 
            // txtValorItem
            // 
            this.txtValorItem.Location = new System.Drawing.Point(26, 130);
            this.txtValorItem.Name = "txtValorItem";
            this.txtValorItem.Size = new System.Drawing.Size(100, 20);
            this.txtValorItem.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Identificador de Item";
            // 
            // txtValorFecha
            // 
            this.txtValorFecha.Location = new System.Drawing.Point(26, 196);
            this.txtValorFecha.Name = "txtValorFecha";
            this.txtValorFecha.Size = new System.Drawing.Size(100, 20);
            this.txtValorFecha.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 177);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Valor Fecha";
            // 
            // txtValorNumerico
            // 
            this.txtValorNumerico.Location = new System.Drawing.Point(26, 256);
            this.txtValorNumerico.Name = "txtValorNumerico";
            this.txtValorNumerico.Size = new System.Drawing.Size(100, 20);
            this.txtValorNumerico.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 237);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Valor numerico";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(26, 343);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Valor Bit Asignable";
            // 
            // txtValorVarchar
            // 
            this.txtValorVarchar.Location = new System.Drawing.Point(26, 311);
            this.txtValorVarchar.Name = "txtValorVarchar";
            this.txtValorVarchar.Size = new System.Drawing.Size(100, 20);
            this.txtValorVarchar.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(26, 292);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Valor Varchar";
            // 
            // tggBitAsignable
            // 
            this.tggBitAsignable.Location = new System.Drawing.Point(26, 362);
            this.tggBitAsignable.Name = "tggBitAsignable";
            this.tggBitAsignable.Properties.OffText = "Off";
            this.tggBitAsignable.Properties.OnText = "On";
            this.tggBitAsignable.Size = new System.Drawing.Size(95, 24);
            this.tggBitAsignable.TabIndex = 16;
            // 
            // cmdRegistrar_Atributo_Equipo
            // 
            this.cmdRegistrar_Atributo_Equipo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrar_Atributo_Equipo.ImageOptions.Image")));
            this.cmdRegistrar_Atributo_Equipo.Location = new System.Drawing.Point(26, 415);
            this.cmdRegistrar_Atributo_Equipo.Name = "cmdRegistrar_Atributo_Equipo";
            this.cmdRegistrar_Atributo_Equipo.Size = new System.Drawing.Size(237, 34);
            this.cmdRegistrar_Atributo_Equipo.TabIndex = 14;
            this.cmdRegistrar_Atributo_Equipo.Text = "REGISTRAR ATRIBUTO DEL EQUIPO";
            this.cmdRegistrar_Atributo_Equipo.Click += new System.EventHandler(this.cmdRegistrar_Atributo_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(95, 455);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 34);
            this.cmdCerrar.TabIndex = 15;
            this.cmdCerrar.Text = "CERRAR";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmCRUDAtributosequipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 489);
            this.Controls.Add(this.tggBitAsignable);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRegistrar_Atributo_Equipo);
            this.Controls.Add(this.txtValorVarchar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtValorNumerico);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtValorFecha);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtValorItem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtIdAtributo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCRUDAtributosequipos";
            this.Text = "frmCRUDAtributosequipos";
            this.Load += new System.EventHandler(this.frmCRUDAtributosequipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAtributo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorNumerico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVarchar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggBitAsignable.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIdAtributo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtValorItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtValorFecha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtValorNumerico;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtValorVarchar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton cmdRegistrar_Atributo_Equipo;
        private DevExpress.XtraEditors.ToggleSwitch tggBitAsignable;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
    }
}