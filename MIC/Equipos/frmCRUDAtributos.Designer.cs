namespace MIC.Equipos
{
    partial class frmCRUDAtributos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDAtributos));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tggEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.tggImprimible = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdRegistrar_Atributo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gleAtributos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSourceAtributos = new System.Windows.Forms.BindingSource(this.components);
            this.dsAtributos1 = new MIC.Equipos.dsAtributos();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggImprimible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAtributos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo de dato";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 137);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(219, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripcion";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // tggEnable
            // 
            this.tggEnable.EditValue = true;
            this.tggEnable.Location = new System.Drawing.Point(24, 199);
            this.tggEnable.Name = "tggEnable";
            this.tggEnable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggEnable.Properties.Appearance.Options.UseFont = true;
            this.tggEnable.Properties.OffText = "NO";
            this.tggEnable.Properties.OnText = "SI";
            this.tggEnable.Size = new System.Drawing.Size(95, 20);
            this.tggEnable.TabIndex = 4;
            // 
            // tggImprimible
            // 
            this.tggImprimible.Location = new System.Drawing.Point(24, 257);
            this.tggImprimible.Name = "tggImprimible";
            this.tggImprimible.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggImprimible.Properties.Appearance.Options.UseFont = true;
            this.tggImprimible.Properties.OffText = "NO";
            this.tggImprimible.Properties.OnText = "SI";
            this.tggImprimible.Size = new System.Drawing.Size(95, 20);
            this.tggImprimible.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 180);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Habilitado";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 238);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Imprimible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gestion de Atributos";
            // 
            // cmdRegistrar_Atributo
            // 
            this.cmdRegistrar_Atributo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrar_Atributo.ImageOptions.Image")));
            this.cmdRegistrar_Atributo.Location = new System.Drawing.Point(24, 303);
            this.cmdRegistrar_Atributo.Name = "cmdRegistrar_Atributo";
            this.cmdRegistrar_Atributo.Size = new System.Drawing.Size(166, 34);
            this.cmdRegistrar_Atributo.TabIndex = 9;
            this.cmdRegistrar_Atributo.Text = "REGISTRAR ATRIBUTO";
            this.cmdRegistrar_Atributo.Click += new System.EventHandler(this.cmdRegistrar_Atributo_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(208, 303);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(86, 34);
            this.cmdCerrar.TabIndex = 10;
            this.cmdCerrar.Text = "CERRAR";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click_1);
            // 
            // gleAtributos
            // 
            this.gleAtributos.EditValue = ".";
            this.gleAtributos.Location = new System.Drawing.Point(24, 86);
            this.gleAtributos.Name = "gleAtributos";
            this.gleAtributos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gleAtributos.Properties.Appearance.Options.UseFont = true;
            this.gleAtributos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleAtributos.Properties.DataSource = this.bindingSourceAtributos;
            this.gleAtributos.Properties.DisplayMember = "descripcion";
            this.gleAtributos.Properties.PopupView = this.gridLookUpEdit1View;
            this.gleAtributos.Properties.ValueMember = "id";
            this.gleAtributos.Size = new System.Drawing.Size(219, 22);
            this.gleAtributos.TabIndex = 11;
            this.gleAtributos.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // bindingSourceAtributos
            // 
            this.bindingSourceAtributos.DataMember = "atributos";
            this.bindingSourceAtributos.DataSource = this.dsAtributos1;
            // 
            // dsAtributos1
            // 
            this.dsAtributos1.DataSetName = "dsAtributos";
            this.dsAtributos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Tipo de datos";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // frmCRUDAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 367);
            this.Controls.Add(this.gleAtributos);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRegistrar_Atributo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tggImprimible);
            this.Controls.Add(this.tggEnable);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCRUDAtributos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Atributos";
            this.Load += new System.EventHandler(this.frmCRUDAtributos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggImprimible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleAtributos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tggEnable;
        private DevExpress.XtraEditors.ToggleSwitch tggImprimible;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmdRegistrar_Atributo;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSourceAtributos;
        private dsAtributos dsAtributos1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        public DevExpress.XtraEditors.GridLookUpEdit gleAtributos;
    }
}