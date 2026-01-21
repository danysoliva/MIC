
namespace MIC.Reportes
{
    partial class mainReportes
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
            this.grdReportes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdluRpts = new DevExpress.XtraEditors.GridLookUpEdit();
            this.reportlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportes1 = new MIC.Reportes.dsReportes();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdluRpts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReportes
            // 
            this.grdReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReportes.Location = new System.Drawing.Point(3, 99);
            this.grdReportes.MainView = this.gridView1;
            this.grdReportes.Name = "grdReportes";
            this.grdReportes.Size = new System.Drawing.Size(1092, 579);
            this.grdReportes.TabIndex = 1;
            this.grdReportes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdReportes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // grdluRpts
            // 
            this.grdluRpts.Location = new System.Drawing.Point(20, 24);
            this.grdluRpts.Name = "grdluRpts";
            this.grdluRpts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdluRpts.Properties.DataSource = this.reportlistBindingSource;
            this.grdluRpts.Properties.DisplayMember = "descripcion";
            this.grdluRpts.Properties.NullText = "";
            this.grdluRpts.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdluRpts.Properties.ValueMember = "id";
            this.grdluRpts.Size = new System.Drawing.Size(332, 20);
            this.grdluRpts.TabIndex = 2;
            this.grdluRpts.EditValueChanged += new System.EventHandler(this.grdluRpts_EditValueChanged);
            // 
            // reportlistBindingSource
            // 
            this.reportlistBindingSource.DataMember = "report_list";
            this.reportlistBindingSource.DataSource = this.dsReportes1;
            // 
            // dsReportes1
            // 
            this.dsReportes1.DataSetName = "dsReportes";
            this.dsReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.coldescripcion.Caption = "Reporte";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cmdGuardar);
            this.groupBox1.Controls.Add(this.grdluRpts);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de Reporte";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::MIC.Properties.Resources.exporttoxlsx_32x32;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(220, 50);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(62, 35);
            this.simpleButton1.TabIndex = 41;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdGuardar.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Appearance.Options.UseBackColor = true;
            this.cmdGuardar.Appearance.Options.UseBorderColor = true;
            this.cmdGuardar.Appearance.Options.UseFont = true;
            this.cmdGuardar.ImageOptions.Image = global::MIC.Properties.Resources.refresh_32x32;
            this.cmdGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(80, 50);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(62, 35);
            this.cmdGuardar.TabIndex = 40;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(478, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 91);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // mainReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdReportes);
            this.Name = "mainReportes";
            ((System.ComponentModel.ISupportInitialize)(this.grdReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdluRpts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdReportes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit grdluRpts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource reportlistBindingSource;
        private dsReportes dsReportes1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.SimpleButton cmdGuardar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}