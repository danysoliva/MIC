
namespace MIC.Equipos
{
    partial class frmAddAtributo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAtributo));
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAgregarAtributo = new DevExpress.XtraEditors.SimpleButton();
            this.txtVarchar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeric = new DevExpress.XtraEditors.TextEdit();
            this.tggEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVarchar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(175, 164);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(115, 34);
            this.cmdCerrar.TabIndex = 22;
            this.cmdCerrar.Text = "CERRAR";
            // 
            // cmdAgregarAtributo
            // 
            this.cmdAgregarAtributo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarAtributo.ImageOptions.Image")));
            this.cmdAgregarAtributo.Location = new System.Drawing.Point(35, 164);
            this.cmdAgregarAtributo.Name = "cmdAgregarAtributo";
            this.cmdAgregarAtributo.Size = new System.Drawing.Size(119, 34);
            this.cmdAgregarAtributo.TabIndex = 21;
            this.cmdAgregarAtributo.Text = "ADD ATRIBUTO";
            this.cmdAgregarAtributo.Click += new System.EventHandler(this.cmdAgregarAtributo_Click);
            // 
            // txtVarchar
            // 
            this.txtVarchar.Location = new System.Drawing.Point(35, 87);
            this.txtVarchar.Name = "txtVarchar";
            this.txtVarchar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVarchar.Properties.Appearance.Options.UseFont = true;
            this.txtVarchar.Size = new System.Drawing.Size(255, 22);
            this.txtVarchar.TabIndex = 2;
            this.txtVarchar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVarchar_KeyDown);
            this.txtVarchar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVarchar_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(90, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 24;
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtributo.Location = new System.Drawing.Point(32, 64);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(108, 16);
            this.lblAtributo.TabIndex = 25;
            this.lblAtributo.Text = "Agregar Atributos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Agregar Atributos";
            // 
            // txtNumeric
            // 
            this.txtNumeric.Location = new System.Drawing.Point(35, 89);
            this.txtNumeric.Name = "txtNumeric";
            this.txtNumeric.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeric.Properties.Appearance.Options.UseFont = true;
            this.txtNumeric.Size = new System.Drawing.Size(255, 22);
            this.txtNumeric.TabIndex = 1;
            this.txtNumeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeric_KeyDown);
            this.txtNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // tggEnable
            // 
            this.tggEnable.Location = new System.Drawing.Point(90, 90);
            this.tggEnable.Name = "tggEnable";
            this.tggEnable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggEnable.Properties.Appearance.Options.UseFont = true;
            this.tggEnable.Properties.OffText = "Off";
            this.tggEnable.Properties.OnText = "On";
            this.tggEnable.Size = new System.Drawing.Size(95, 20);
            this.tggEnable.TabIndex = 3;
            this.tggEnable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tggEnable_KeyDown);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(35, 89);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(255, 22);
            this.dateEdit1.TabIndex = 0;
            this.dateEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateEdit1_KeyDown);
            // 
            // frmAddAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 255);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.tggEnable);
            this.Controls.Add(this.txtNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAtributo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtVarchar);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdAgregarAtributo);
            this.Name = "frmAddAtributo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Atributos";
            this.Load += new System.EventHandler(this.frmAddAtributo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtVarchar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdAgregarAtributo;
        private DevExpress.XtraEditors.TextEdit txtVarchar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNumeric;
        private DevExpress.XtraEditors.ToggleSwitch tggEnable;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}