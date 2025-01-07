namespace MIC.Equipos
{
    partial class frmHOMEAtributos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOMEAtributos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cmdNuevoAtributo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlHomeAtributos = new DevExpress.XtraGrid.GridControl();
            this.dsAtributos1 = new MIC.Equipos.dsAtributos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_dato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimprimible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDescripcionTipoDato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tggVerTodos = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.atributosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHomeAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNuevoAtributo
            // 
            this.cmdNuevoAtributo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoAtributo.ImageOptions.Image")));
            this.cmdNuevoAtributo.Location = new System.Drawing.Point(12, 12);
            this.cmdNuevoAtributo.Name = "cmdNuevoAtributo";
            this.cmdNuevoAtributo.Size = new System.Drawing.Size(85, 34);
            this.cmdNuevoAtributo.TabIndex = 15;
            this.cmdNuevoAtributo.Text = "NUEVO";
            this.cmdNuevoAtributo.Click += new System.EventHandler(this.cmdNuevoAtributo_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(651, 12);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(85, 34);
            this.cmdSalir.TabIndex = 16;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // gridControlHomeAtributos
            // 
            this.gridControlHomeAtributos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlHomeAtributos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControlHomeAtributos.BackgroundImage")));
            this.gridControlHomeAtributos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gridControlHomeAtributos.DataMember = "HOMEAtributos";
            this.gridControlHomeAtributos.DataSource = this.dsAtributos1;
            this.gridControlHomeAtributos.Location = new System.Drawing.Point(1, 46);
            this.gridControlHomeAtributos.MainView = this.gridView1;
            this.gridControlHomeAtributos.Name = "gridControlHomeAtributos";
            this.gridControlHomeAtributos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar});
            this.gridControlHomeAtributos.Size = new System.Drawing.Size(782, 406);
            this.gridControlHomeAtributos.TabIndex = 17;
            this.gridControlHomeAtributos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlHomeAtributos.Click += new System.EventHandler(this.gridControlHomeAtributos_Click);
            // 
            // dsAtributos1
            // 
            this.dsAtributos1.DataSetName = "dsAtributos";
            this.dsAtributos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_tipo_dato,
            this.coldescripcion,
            this.colenable,
            this.colimprimible,
            this.colEditar,
            this.colDescripcionTipoDato});
            this.gridView1.GridControl = this.gridControlHomeAtributos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colid.AppearanceCell.Options.UseBackColor = true;
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colid_tipo_dato
            // 
            this.colid_tipo_dato.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colid_tipo_dato.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colid_tipo_dato.AppearanceCell.BorderColor = System.Drawing.Color.White;
            this.colid_tipo_dato.AppearanceCell.Options.UseBackColor = true;
            this.colid_tipo_dato.AppearanceCell.Options.UseBorderColor = true;
            this.colid_tipo_dato.AppearanceHeader.BackColor = System.Drawing.Color.Transparent;
            this.colid_tipo_dato.AppearanceHeader.Options.UseBackColor = true;
            this.colid_tipo_dato.FieldName = "id_tipo_dato";
            this.colid_tipo_dato.Name = "colid_tipo_dato";
            this.colid_tipo_dato.Visible = true;
            this.colid_tipo_dato.VisibleIndex = 1;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            // 
            // colenable
            // 
            this.colenable.Caption = "Habilitado";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 4;
            // 
            // colimprimible
            // 
            this.colimprimible.FieldName = "imprimible";
            this.colimprimible.Name = "colimprimible";
            this.colimprimible.Visible = true;
            this.colimprimible.VisibleIndex = 5;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 6;
            // 
            // cmdEditar
            // 
            this.cmdEditar.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditar.Appearance.Image")));
            this.cmdEditar.Appearance.Options.UseImage = true;
            this.cmdEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdEditar_Click);
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // colDescripcionTipoDato
            // 
            this.colDescripcionTipoDato.Caption = "Tipo de Dato";
            this.colDescripcionTipoDato.FieldName = "TipoDato";
            this.colDescripcionTipoDato.Name = "colDescripcionTipoDato";
            this.colDescripcionTipoDato.Visible = true;
            this.colDescripcionTipoDato.VisibleIndex = 2;
            // 
            // tggVerTodos
            // 
            this.tggVerTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tggVerTodos.Location = new System.Drawing.Point(538, 16);
            this.tggVerTodos.Name = "tggVerTodos";
            this.tggVerTodos.Properties.OffText = "NO";
            this.tggVerTodos.Properties.OnText = "SI";
            this.tggVerTodos.Size = new System.Drawing.Size(93, 18);
            this.tggVerTodos.TabIndex = 18;
            this.tggVerTodos.Toggled += new System.EventHandler(this.tggVerTodos_Toggled);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "VER HABILITADOS";
            // 
            // atributosBindingSource
            // 
            this.atributosBindingSource.DataMember = "atributos";
            this.atributosBindingSource.DataSource = this.dsAtributos1;
            // 
            // frmHOMEAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MIC.Properties.Resources.suministro_instalacion_equipos_informaticos_y_redes;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggVerTodos);
            this.Controls.Add(this.gridControlHomeAtributos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdNuevoAtributo);
            this.Name = "frmHOMEAtributos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Atributos";
            this.Load += new System.EventHandler(this.frmHOMEAtributos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHomeAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdNuevoAtributo;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private DevExpress.XtraGrid.GridControl gridControlHomeAtributos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_dato;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colimprimible;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private dsAtributos dsAtributos1;
        private DevExpress.XtraEditors.ToggleSwitch tggVerTodos;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionTipoDato;
        private System.Windows.Forms.BindingSource atributosBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}