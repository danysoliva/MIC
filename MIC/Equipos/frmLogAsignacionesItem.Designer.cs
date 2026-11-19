namespace MIC.Equipos
{
    partial class frmLogAsignacionesItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.lblItem = new DevExpress.XtraEditors.LabelControl();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colusuario_asignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colit_usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_asignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hora_asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_devolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotivo_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Controls.Add(this.lblItem);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1080, 64);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Log de asignaciones";
            // 
            // lblItem
            // 
            this.lblItem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblItem.Appearance.Options.UseFont = true;
            this.lblItem.Location = new System.Drawing.Point(12, 36);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(0, 16);
            this.lblItem.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(984, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1080, 476);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colusuario_asignado,
            this.colit_usuario,
            this.coltipo_item,
            this.colfecha_asignado,
            this.colfecha_hora_asignacion,
            this.coldate_end,
            this.colfecha_devolucion,
            this.colmotivo_end,
            this.colenable});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colusuario_asignado
            // 
            this.colusuario_asignado.Caption = "Usuario asignado";
            this.colusuario_asignado.FieldName = "usuario_asignado";
            this.colusuario_asignado.Name = "colusuario_asignado";
            this.colusuario_asignado.Visible = true;
            this.colusuario_asignado.VisibleIndex = 0;
            this.colusuario_asignado.Width = 180;
            // 
            // colit_usuario
            // 
            this.colit_usuario.Caption = "Usuario IT";
            this.colit_usuario.FieldName = "it_usuario_transaccion";
            this.colit_usuario.Name = "colit_usuario";
            this.colit_usuario.Visible = true;
            this.colit_usuario.VisibleIndex = 1;
            this.colit_usuario.Width = 160;
            // 
            // coltipo_item
            // 
            this.coltipo_item.Caption = "Tipo";
            this.coltipo_item.FieldName = "tipo_item";
            this.coltipo_item.Name = "coltipo_item";
            this.coltipo_item.Visible = true;
            this.coltipo_item.VisibleIndex = 2;
            this.coltipo_item.Width = 120;
            // 
            // colfecha_asignado
            // 
            this.colfecha_asignado.Caption = "Fecha asignación";
            this.colfecha_asignado.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colfecha_asignado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_asignado.FieldName = "fecha_asignado";
            this.colfecha_asignado.Name = "colfecha_asignado";
            this.colfecha_asignado.Visible = true;
            this.colfecha_asignado.VisibleIndex = 3;
            this.colfecha_asignado.Width = 140;
            // 
            // colfecha_hora_asignacion
            // 
            this.colfecha_hora_asignacion.Caption = "Fecha registro";
            this.colfecha_hora_asignacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colfecha_hora_asignacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_hora_asignacion.FieldName = "fecha_hora_asignacion";
            this.colfecha_hora_asignacion.Name = "colfecha_hora_asignacion";
            this.colfecha_hora_asignacion.Visible = true;
            this.colfecha_hora_asignacion.VisibleIndex = 4;
            this.colfecha_hora_asignacion.Width = 140;
            // 
            // coldate_end
            // 
            this.coldate_end.Caption = "Fecha fin";
            this.coldate_end.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.coldate_end.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldate_end.FieldName = "date_end";
            this.coldate_end.Name = "coldate_end";
            this.coldate_end.Visible = true;
            this.coldate_end.VisibleIndex = 5;
            this.coldate_end.Width = 140;
            // 
            // colfecha_devolucion
            // 
            this.colfecha_devolucion.Caption = "Fecha devolución";
            this.colfecha_devolucion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colfecha_devolucion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_devolucion.FieldName = "fecha_devolucion";
            this.colfecha_devolucion.Name = "colfecha_devolucion";
            this.colfecha_devolucion.Visible = true;
            this.colfecha_devolucion.VisibleIndex = 6;
            this.colfecha_devolucion.Width = 140;
            // 
            // colmotivo_end
            // 
            this.colmotivo_end.Caption = "Motivo";
            this.colmotivo_end.FieldName = "motivo_end";
            this.colmotivo_end.Name = "colmotivo_end";
            this.colmotivo_end.Visible = true;
            this.colmotivo_end.VisibleIndex = 7;
            this.colmotivo_end.Width = 220;
            // 
            // colenable
            // 
            this.colenable.Caption = "Activo";
            this.colenable.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Visible = true;
            this.colenable.VisibleIndex = 8;
            this.colenable.Width = 70;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frmLogAsignacionesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 540);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelTop);
            this.Name = "frmLogAsignacionesItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log de asignaciones";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.LabelControl lblItem;
        private DevExpress.XtraEditors.SimpleButton btnCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario_asignado;
        private DevExpress.XtraGrid.Columns.GridColumn colit_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_item;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_asignado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hora_asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_end;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_devolucion;
        private DevExpress.XtraGrid.Columns.GridColumn colmotivo_end;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
