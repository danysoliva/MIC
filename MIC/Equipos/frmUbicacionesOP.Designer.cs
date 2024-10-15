
namespace MIC.Equipos
{
    partial class frmUbicacionesOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUbicacionesOP));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tggenable = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUbicaciones = new DevExpress.XtraEditors.TextEdit();
            this.btnaddUbicacion = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.dsItems1 = new MIC.Equipos.dsItems();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdRegistrarItem = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbicaciones.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 21);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Activo:";
            this.labelControl2.Visible = false;
            // 
            // tggenable
            // 
            this.tggenable.EditValue = true;
            this.tggenable.Location = new System.Drawing.Point(180, 101);
            this.tggenable.Name = "tggenable";
            this.tggenable.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggenable.Properties.Appearance.Options.UseFont = true;
            this.tggenable.Properties.OffText = "Deshabilitado";
            this.tggenable.Properties.OnText = "Habilitado";
            this.tggenable.Size = new System.Drawing.Size(319, 26);
            this.tggenable.TabIndex = 18;
            this.tggenable.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(79, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 21);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Localidad:";
            // 
            // txtUbicaciones
            // 
            this.txtUbicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUbicaciones.Location = new System.Drawing.Point(180, 41);
            this.txtUbicaciones.Name = "txtUbicaciones";
            this.txtUbicaciones.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicaciones.Properties.Appearance.Options.UseFont = true;
            this.txtUbicaciones.Properties.MaxLength = 70;
            this.txtUbicaciones.Size = new System.Drawing.Size(221, 28);
            this.txtUbicaciones.TabIndex = 16;
            // 
            // btnaddUbicacion
            // 
            this.btnaddUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddUbicacion.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddUbicacion.Appearance.Options.UseFont = true;
            this.btnaddUbicacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnaddUbicacion.ImageOptions.Image")));
            this.btnaddUbicacion.Location = new System.Drawing.Point(518, 109);
            this.btnaddUbicacion.Name = "btnaddUbicacion";
            this.btnaddUbicacion.Size = new System.Drawing.Size(179, 42);
            this.btnaddUbicacion.TabIndex = 15;
            this.btnaddUbicacion.Text = "Agregar Ubicacion";
            this.btnaddUbicacion.Click += new System.EventHandler(this.btnaddUbicacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd_data);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 426);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicaciones";
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "ubicacion";
            this.grd_data.DataSource = this.dsItems1;
            this.grd_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_data.Location = new System.Drawing.Point(3, 25);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btneliminar});
            this.grd_data.Size = new System.Drawing.Size(689, 398);
            this.grd_data.TabIndex = 0;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // dsItems1
            // 
            this.dsItems1.DataSetName = "dsItems";
            this.dsItems1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupFooter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupFooter.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.GroupRow.Options.UseFont = true;
            this.grdv_data.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdv_data.Appearance.Preview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Preview.Options.UseFont = true;
            this.grdv_data.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.Row.Options.UseFont = true;
            this.grdv_data.Appearance.TopNewRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdv_data.Appearance.TopNewRow.Options.UseFont = true;
            this.grdv_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldetalle,
            this.coleliminar,
            this.id});
            this.grdv_data.GridControl = this.grd_data;
            this.grdv_data.Name = "grdv_data";
            this.grdv_data.OptionsView.ShowAutoFilterRow = true;
            this.grdv_data.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coldetalle
            // 
            this.coldetalle.Caption = "Ubicacion";
            this.coldetalle.FieldName = "descripcion";
            this.coldetalle.Name = "coldetalle";
            this.coldetalle.OptionsColumn.AllowEdit = false;
            this.coldetalle.Visible = true;
            this.coldetalle.VisibleIndex = 0;
            this.coldetalle.Width = 538;
            // 
            // coleliminar
            // 
            this.coleliminar.Caption = "Editar";
            this.coleliminar.ColumnEdit = this.btneliminar;
            this.coleliminar.Name = "coleliminar";
            this.coleliminar.Visible = true;
            this.coleliminar.VisibleIndex = 1;
            this.coleliminar.Width = 93;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btneliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btneliminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btneliminar_ButtonClick);
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // cmdRegistrarItem
            // 
            this.cmdRegistrarItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarItem.ImageOptions.Image")));
            this.cmdRegistrarItem.Location = new System.Drawing.Point(180, 599);
            this.cmdRegistrarItem.Name = "cmdRegistrarItem";
            this.cmdRegistrarItem.Size = new System.Drawing.Size(164, 34);
            this.cmdRegistrarItem.TabIndex = 20;
            this.cmdRegistrarItem.Text = "REGISTRAR UBICACION";
            this.cmdRegistrarItem.Click += new System.EventHandler(this.cmdRegistrarItem_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(350, 599);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(115, 34);
            this.cmdCerrar.TabIndex = 21;
            this.cmdCerrar.Text = "CERRAR";
            // 
            // frmUbicacionesOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 656);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRegistrarItem);
            this.Controls.Add(this.btnaddUbicacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tggenable);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtUbicaciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUbicacionesOP";
            this.Text = "frmUbicacionesOP";
            this.Load += new System.EventHandler(this.frmUbicacionesOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tggenable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbicaciones.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tggenable;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUbicaciones;
        private DevExpress.XtraEditors.SimpleButton btnaddUbicacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldetalle;
        private DevExpress.XtraGrid.Columns.GridColumn coleliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btneliminar;
        private DevExpress.XtraEditors.SimpleButton cmdRegistrarItem;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private dsItems dsItems1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
    }
}