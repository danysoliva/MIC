
namespace MIC.Message
{
    partial class frmOpcionMotivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcionMotivo));
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdAgregarAtributo = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Siemens Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Motivo de la devolucion";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 33;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(164, 162);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(115, 34);
            this.cmdCerrar.TabIndex = 32;
            this.cmdCerrar.Text = "CERRAR";
            // 
            // cmdAgregarAtributo
            // 
            this.cmdAgregarAtributo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarAtributo.ImageOptions.Image")));
            this.cmdAgregarAtributo.Location = new System.Drawing.Point(24, 162);
            this.cmdAgregarAtributo.Name = "cmdAgregarAtributo";
            this.cmdAgregarAtributo.Size = new System.Drawing.Size(119, 34);
            this.cmdAgregarAtributo.TabIndex = 31;
            this.cmdAgregarAtributo.Text = "ADD ATRIBUTO";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(24, 103);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "BAJA DE EQUIPOS",
            "RENOVACION ",
            "FINALIZACION DE CONTRATO"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(255, 20);
            this.comboBoxEdit1.TabIndex = 36;
            // 
            // frmOpcionMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 250);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdAgregarAtributo);
            this.Name = "frmOpcionMotivo";
            this.Text = "frmOpcionMotivo";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraEditors.SimpleButton cmdAgregarAtributo;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}