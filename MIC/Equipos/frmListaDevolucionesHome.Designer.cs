namespace MIC.Equipos
{
    partial class frmListaDevolucionesHome
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
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_it_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_asig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmotivo_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Controls.Add(this.btnAgregar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 48);
            this.panelTop.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCerrar.Appearance.Options.UseBackColor = true;
            this.btnCerrar.Location = new System.Drawing.Point(888, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 32);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Location = new System.Drawing.Point(12, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 473);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_item,
            this.gridColumn1,
            this.gridColumn2,
            this.colid_it_user,
            this.colUserIT,
            this.coldate_asig,
            this.colenable,
            this.coldate_end,
            this.colcreated,
            this.colid_user,
            this.gridColumn3,
            this.colmotivo_end,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Width = 70;
            // 
            // colid_item
            // 
            this.colid_item.Caption = "Item";
            this.colid_item.FieldName = "id_item";
            this.colid_item.Name = "colid_item";
            this.colid_item.Width = 80;
            // 
            // colid_it_user
            // 
            this.colid_it_user.Caption = "Usuario IT id";
            this.colid_it_user.FieldName = "id_it_user";
            this.colid_it_user.Name = "colid_it_user";
            this.colid_it_user.Width = 90;
            // 
            // coldate_asig
            // 
            this.coldate_asig.Caption = "Fecha asignación";
            this.coldate_asig.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.coldate_asig.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldate_asig.FieldName = "fecha_asignado";
            this.coldate_asig.Name = "coldate_asig";
            this.coldate_asig.Visible = true;
            this.coldate_asig.VisibleIndex = 2;
            this.coldate_asig.Width = 99;
            // 
            // colenable
            // 
            this.colenable.Caption = "Activo";
            this.colenable.FieldName = "enable";
            this.colenable.Name = "colenable";
            this.colenable.Width = 70;
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
            this.coldate_end.Width = 71;
            // 
            // colcreated
            // 
            this.colcreated.Caption = "Creado";
            this.colcreated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colcreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colcreated.FieldName = "created";
            this.colcreated.Name = "colcreated";
            this.colcreated.Visible = true;
            this.colcreated.VisibleIndex = 6;
            this.colcreated.Width = 65;
            // 
            // colid_user
            // 
            this.colid_user.Caption = "Usuario";
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.Width = 80;
            // 
            // colmotivo_end
            // 
            this.colmotivo_end.Caption = "Motivo fin";
            this.colmotivo_end.FieldName = "motivo_end";
            this.colmotivo_end.Name = "colmotivo_end";
            this.colmotivo_end.Visible = true;
            this.colmotivo_end.VisibleIndex = 7;
            this.colmotivo_end.Width = 160;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Item Name";
            this.gridColumn1.FieldName = "itemname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 160;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo";
            this.gridColumn2.FieldName = "tipo_item";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 103;
            // 
            // colUserIT
            // 
            this.colUserIT.Caption = "Usuario IT";
            this.colUserIT.FieldName = "it_usuario_transaccion";
            this.colUserIT.Name = "colUserIT";
            this.colUserIT.Visible = true;
            this.colUserIT.VisibleIndex = 4;
            this.colUserIT.Width = 76;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Usuario Asignado";
            this.gridColumn3.FieldName = "usuario_asignado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 92;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha Devolución";
            this.gridColumn4.FieldName = "fecha_devolucion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 90;
            // 
            // frmListaDevolucionesHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelTop);
            this.Name = "frmListaDevolucionesHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnCerrar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_item;
        private DevExpress.XtraGrid.Columns.GridColumn colid_it_user;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_asig;
        private DevExpress.XtraGrid.Columns.GridColumn colenable;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_end;
        private DevExpress.XtraGrid.Columns.GridColumn colcreated;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn colmotivo_end;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
