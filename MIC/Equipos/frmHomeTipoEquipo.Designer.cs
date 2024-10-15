
namespace MIC.Equipos
{
    partial class frmHomeTipoEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeTipoEquipo));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnnuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnclose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControlTipoEquipo = new DevExpress.XtraGrid.GridControl();
            this.dsAtributos1 = new MIC.Equipos.dsAtributos();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnnuevo,
            this.btnclose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnnuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnclose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Caption = "Nuevo";
            this.btnnuevo.Id = 1;
            this.btnnuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.ImageOptions.Image")));
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnnuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnuevo_ItemClick);
            // 
            // btnclose
            // 
            this.btnclose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnclose.Caption = "Cerrar";
            this.btnclose.Id = 2;
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnclose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnclose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(506, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 618);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(506, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 578);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(506, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 578);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // gridControlTipoEquipo
            // 
            this.gridControlTipoEquipo.DataMember = "TablesID";
            this.gridControlTipoEquipo.DataSource = this.dsAtributos1;
            this.gridControlTipoEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTipoEquipo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControlTipoEquipo.Location = new System.Drawing.Point(0, 40);
            this.gridControlTipoEquipo.MainView = this.grdv_data;
            this.gridControlTipoEquipo.MenuManager = this.barManager1;
            this.gridControlTipoEquipo.Name = "gridControlTipoEquipo";
            this.gridControlTipoEquipo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditar});
            this.gridControlTipoEquipo.Size = new System.Drawing.Size(506, 578);
            this.gridControlTipoEquipo.TabIndex = 7;
            this.gridControlTipoEquipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsAtributos1
            // 
            this.dsAtributos1.DataSetName = "dsAtributos";
            this.dsAtributos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.GroupPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescripcion,
            this.colenable,
            this.colEditar});
            this.grdv_data.GridControl = this.gridControlTipoEquipo;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Tipo de Equipos";
            this.coldescripcion.FieldName = "descripcion_mostrar";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 339;
            // 
            // colenable
            // 
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.OptionsColumn.AllowEdit = false;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.btnEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 1;
            this.colEditar.Width = 109;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmHomeTipoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 618);
            this.Controls.Add(this.gridControlTipoEquipo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHomeTipoEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomeTipoEquipo";
            this.Load += new System.EventHandler(this.frmHomeTipoEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnnuevo;
        private DevExpress.XtraBars.BarButtonItem btnclose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlTipoEquipo;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private dsAtributos dsAtributos1;
    }
}