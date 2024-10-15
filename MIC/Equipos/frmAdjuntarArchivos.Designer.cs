
namespace MIC.Equipos
{
    partial class frmAdjuntarArchivos
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjuntarArchivos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlAdjuntos = new DevExpress.XtraGrid.GridControl();
            this.dsItems1 = new MIC.Equipos.dsItems();
            this.grdv_seguimiento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDescargar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOpen = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnArchivo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.cmdUpload = new DevExpress.XtraEditors.SimpleButton();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdjuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlAdjuntos
            // 
            this.gridControlAdjuntos.DataMember = "archivos";
            this.gridControlAdjuntos.DataSource = this.dsItems1;
            this.gridControlAdjuntos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlAdjuntos.Location = new System.Drawing.Point(0, 82);
            this.gridControlAdjuntos.MainView = this.grdv_seguimiento;
            this.gridControlAdjuntos.Name = "gridControlAdjuntos";
            this.gridControlAdjuntos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnArchivo,
            this.repositoryItemHyperLinkEdit1,
            this.btnDescargar,
            this.btnOpen,
            this.btnDelete});
            this.gridControlAdjuntos.Size = new System.Drawing.Size(742, 491);
            this.gridControlAdjuntos.TabIndex = 3;
            this.gridControlAdjuntos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_seguimiento});
            // 
            // dsItems1
            // 
            this.dsItems1.DataSetName = "dsItems";
            this.dsItems1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_seguimiento
            // 
            this.grdv_seguimiento.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_seguimiento.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdv_seguimiento.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdv_seguimiento.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.Preview.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_seguimiento.Appearance.Row.Options.UseFont = true;
            this.grdv_seguimiento.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_seguimiento.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_seguimiento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPath,
            this.colFileName,
            this.colid,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grdv_seguimiento.GridControl = this.gridControlAdjuntos;
            this.grdv_seguimiento.Name = "grdv_seguimiento";
            this.grdv_seguimiento.OptionsView.ShowAutoFilterRow = true;
            this.grdv_seguimiento.OptionsView.ShowGroupPanel = false;
            // 
            // colPath
            // 
            this.colPath.FieldName = "Path";
            this.colPath.MinWidth = 21;
            this.colPath.Name = "colPath";
            this.colPath.Width = 81;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "File Name";
            this.colFileName.FieldName = "fileName";
            this.colFileName.MinWidth = 21;
            this.colFileName.Name = "colFileName";
            this.colFileName.OptionsColumn.AllowEdit = false;
            this.colFileName.OptionsFilter.AllowFilter = false;
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 475;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 21;
            this.colid.Name = "colid";
            this.colid.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descargar";
            this.gridColumn1.ColumnEdit = this.btnDescargar;
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 90;
            // 
            // btnDescargar
            // 
            this.btnDescargar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDescargar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDescargar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDescargar_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ver";
            this.gridColumn2.ColumnEdit = this.btnOpen;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 104;
            // 
            // btnOpen
            // 
            this.btnOpen.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnOpen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnOpen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnOpen_ButtonClick);
            // 
            // btnArchivo
            // 
            this.btnArchivo.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnArchivo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // cmdUpload
            // 
            this.cmdUpload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpload.ImageOptions.Image")));
            this.cmdUpload.Location = new System.Drawing.Point(25, 26);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(103, 34);
            this.cmdUpload.TabIndex = 21;
            this.cmdUpload.Text = "CARGAR";
            this.cmdUpload.Click += new System.EventHandler(this.cmdNuevoAtributo_Click);
            // 
            // Dialog
            // 
            this.Dialog.FileName = "Dialog";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDelete_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Eliminar";
            this.gridColumn3.ColumnEdit = this.btnDelete;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // frmAdjuntarArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 573);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.gridControlAdjuntos);
            this.Name = "frmAdjuntarArchivos";
            this.Text = "frmAdjuntarArchivos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdjuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_seguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAdjuntos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_seguimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colPath;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDescargar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOpen;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnArchivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdUpload;
        private System.Windows.Forms.OpenFileDialog Dialog;
        private dsItems dsItems1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
    }
}