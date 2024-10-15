namespace MIC.Equipos
{
    partial class frmHomeItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeItems));
            this.label1 = new System.Windows.Forms.Label();
            this.tggVerTodos = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridControlHomeAtributos = new DevExpress.XtraGrid.GridControl();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItems = new MIC.Equipos.dsItems();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitems_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_equipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbit_asignable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colcreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.cmdSalir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevoItems = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tggVerTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHomeAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "VER HABILITADOS";
            // 
            // tggVerTodos
            // 
            this.tggVerTodos.Location = new System.Drawing.Point(566, 1);
            this.tggVerTodos.Name = "tggVerTodos";
            this.tggVerTodos.Properties.OffText = "NO";
            this.tggVerTodos.Properties.OnText = "SI";
            this.tggVerTodos.Size = new System.Drawing.Size(93, 24);
            this.tggVerTodos.TabIndex = 23;
            this.tggVerTodos.Toggled += new System.EventHandler(this.tggVerTodos_Toggled_1);
            // 
            // gridControlHomeAtributos
            // 
            this.gridControlHomeAtributos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControlHomeAtributos.BackgroundImage")));
            this.gridControlHomeAtributos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gridControlHomeAtributos.DataSource = this.itemsBindingSource;
            this.gridControlHomeAtributos.Location = new System.Drawing.Point(25, 31);
            this.gridControlHomeAtributos.MainView = this.gridView1;
            this.gridControlHomeAtributos.Name = "gridControlHomeAtributos";
            this.gridControlHomeAtributos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdEditar,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemFontEdit1});
            this.gridControlHomeAtributos.Size = new System.Drawing.Size(763, 392);
            this.gridControlHomeAtributos.TabIndex = 22;
            this.gridControlHomeAtributos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.dsItemsBindingSource;
            // 
            // dsItemsBindingSource
            // 
            this.dsItemsBindingSource.DataSource = this.dsItems;
            this.dsItemsBindingSource.Position = 0;
            // 
            // dsItems
            // 
            this.dsItems.DataSetName = "dsItems";
            this.dsItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.ColumnFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("gridView1.Appearance.ColumnFilterButton.Image")));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseImage = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colitems_code,
            this.colnombre,
            this.colid_tipo_equipo,
            this.colenable,
            this.colmarca,
            this.colcomentario,
            this.colbit_asignable,
            this.colcreated,
            this.colid_estado,
            this.colEditar});
            this.gridView1.GridControl = this.gridControlHomeAtributos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 67;
            // 
            // colitems_code
            // 
            this.colitems_code.FieldName = "items_code";
            this.colitems_code.Name = "colitems_code";
            this.colitems_code.Visible = true;
            this.colitems_code.VisibleIndex = 1;
            this.colitems_code.Width = 67;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 2;
            this.colnombre.Width = 67;
            // 
            // colid_tipo_equipo
            // 
            this.colid_tipo_equipo.Caption = "Id Tipo De Equipo";
            this.colid_tipo_equipo.FieldName = "id_tipo_equipo";
            this.colid_tipo_equipo.Name = "colid_tipo_equipo";
            this.colid_tipo_equipo.Visible = true;
            this.colid_tipo_equipo.VisibleIndex = 3;
            this.colid_tipo_equipo.Width = 66;
            // 
            // colenable
            // 
            this.colenable.Caption = "Enable";
            this.colenable.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 4;
            this.colenable.Width = 66;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // colmarca
            // 
            this.colmarca.Caption = "Marca";
            this.colmarca.FieldName = "marca";
            this.colmarca.Name = "colmarca";
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 5;
            this.colmarca.Width = 66;
            // 
            // colcomentario
            // 
            this.colcomentario.Caption = "Comentario";
            this.colcomentario.FieldName = "comentario";
            this.colcomentario.Name = "colcomentario";
            this.colcomentario.Visible = true;
            this.colcomentario.VisibleIndex = 6;
            this.colcomentario.Width = 66;
            // 
            // colbit_asignable
            // 
            this.colbit_asignable.Caption = "Asignable";
            this.colbit_asignable.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colbit_asignable.FieldName = "bit_asignable";
            this.colbit_asignable.Name = "colbit_asignable";
            this.colbit_asignable.Visible = true;
            this.colbit_asignable.VisibleIndex = 7;
            this.colbit_asignable.Width = 66;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colcreated
            // 
            this.colcreated.Name = "colcreated";
            this.colcreated.Visible = true;
            this.colcreated.VisibleIndex = 8;
            this.colcreated.Width = 66;
            // 
            // colid_estado
            // 
            this.colid_estado.Caption = "Id Estado";
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            this.colid_estado.Visible = true;
            this.colid_estado.VisibleIndex = 9;
            this.colid_estado.Width = 66;
            // 
            // colEditar
            // 
            this.colEditar.Caption = "Editar";
            this.colEditar.ColumnEdit = this.cmdEditar;
            this.colEditar.Name = "colEditar";
            this.colEditar.Visible = true;
            this.colEditar.VisibleIndex = 10;
            this.colEditar.Width = 82;
            // 
            // cmdEditar
            // 
            this.cmdEditar.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditar.Appearance.Image")));
            this.cmdEditar.Appearance.Options.UseImage = true;
            this.cmdEditar.AutoHeight = false;
            this.cmdEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // cmdSalir
            // 
            this.cmdSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalir.ImageOptions.Image")));
            this.cmdSalir.Location = new System.Drawing.Point(703, -3);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(85, 34);
            this.cmdSalir.TabIndex = 21;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdNuevoItems
            // 
            this.cmdNuevoItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoItems.ImageOptions.Image")));
            this.cmdNuevoItems.Location = new System.Drawing.Point(25, -3);
            this.cmdNuevoItems.Name = "cmdNuevoItems";
            this.cmdNuevoItems.Size = new System.Drawing.Size(85, 34);
            this.cmdNuevoItems.TabIndex = 20;
            this.cmdNuevoItems.Text = "NUEVO";
            this.cmdNuevoItems.Click += new System.EventHandler(this.cmdNuevoItems_Click);
            // 
            // frmHomeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tggVerTodos);
            this.Controls.Add(this.gridControlHomeAtributos);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdNuevoItems);
            this.Name = "frmHomeItems";
            this.Text = "frmHomeItems";
            this.Load += new System.EventHandler(this.frmHomeItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tggVerTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHomeAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ToggleSwitch tggVerTodos;
        private DevExpress.XtraGrid.GridControl gridControlHomeAtributos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdEditar;
        private DevExpress.XtraEditors.SimpleButton cmdSalir;
        private DevExpress.XtraEditors.SimpleButton cmdNuevoItems;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colitems_code;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_equipo;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraGrid.Columns.GridColumn colcomentario;
        private DevExpress.XtraGrid.Columns.GridColumn colbit_asignable;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource dsItemsBindingSource;
        private dsItems dsItems;
    }
}