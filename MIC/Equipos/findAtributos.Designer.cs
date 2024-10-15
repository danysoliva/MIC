
namespace MIC.Equipos
{
    partial class findAtributos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findAtributos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bindingSourceAtributos = new System.Windows.Forms.BindingSource(this.components);
            this.dsAtributos1 = new MIC.Equipos.dsAtributos();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colatributo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnagregar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            this.SuspendLayout();
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
            // cmdCerrar
            // 
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(466, 12);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(115, 34);
            this.cmdCerrar.TabIndex = 21;
            this.cmdCerrar.Text = "CERRAR";
            // 
            // grd_data
            // 
            this.grd_data.DataMember = null;
            this.grd_data.DataSource = this.bindingSourceAtributos;
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(0, 0);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnagregar});
            this.grd_data.Size = new System.Drawing.Size(593, 581);
            this.grd_data.TabIndex = 22;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            this.grd_data.Click += new System.EventHandler(this.grd_data_Click_1);
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FilterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colatributo,
            this.coledit});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colatributo
            // 
            this.colatributo.Caption = "Atributo";
            this.colatributo.FieldName = "descripcion";
            this.colatributo.Name = "colatributo";
            this.colatributo.Visible = true;
            this.colatributo.VisibleIndex = 0;
            this.colatributo.Width = 570;
            // 
            // coledit
            // 
            this.coledit.Caption = "Seleccionar";
            this.coledit.ColumnEdit = this.btnagregar;
            this.coledit.FieldName = "seleccionado";
            this.coledit.Name = "coledit";
            this.coledit.Visible = true;
            this.coledit.VisibleIndex = 1;
            this.coledit.Width = 133;
            // 
            // btnagregar
            // 
            this.btnagregar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnagregar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnagregar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnagregar_ButtonClick);
            // 
            // findAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 581);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.cmdCerrar);
            this.Name = "findAtributos";
            this.Text = "findAtributos";
            this.Load += new System.EventHandler(this.findAtributos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private dsAtributos dsAtributos1;
        private System.Windows.Forms.BindingSource bindingSourceAtributos;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colatributo;
        private DevExpress.XtraGrid.Columns.GridColumn coledit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnagregar;
    }
}