
namespace MIC.Equipos
{
    partial class frmTipoEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoEquipos));
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionCompleta = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSiguiente = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tggEnable = new DevExpress.XtraEditors.ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dsAtributos1 = new MIC.Equipos.dsAtributos();
            this.grd_data = new DevExpress.XtraGrid.GridControl();
            this.grdv_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colatributo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddAtributo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdRegistrarItem = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCompleta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSiguiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(42, 93);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(243, 26);
            this.txtDescripcion.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Descripcion:";
            // 
            // txtDescripcionCompleta
            // 
            this.txtDescripcionCompleta.Location = new System.Drawing.Point(42, 148);
            this.txtDescripcionCompleta.Name = "txtDescripcionCompleta";
            this.txtDescripcionCompleta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCompleta.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcionCompleta.Size = new System.Drawing.Size(243, 26);
            this.txtDescripcionCompleta.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripcion Completa:";
            // 
            // txtIdSiguiente
            // 
            this.txtIdSiguiente.Enabled = false;
            this.txtIdSiguiente.Location = new System.Drawing.Point(42, 205);
            this.txtIdSiguiente.Name = "txtIdSiguiente";
            this.txtIdSiguiente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSiguiente.Properties.Appearance.Options.UseFont = true;
            this.txtIdSiguiente.Size = new System.Drawing.Size(243, 26);
            this.txtIdSiguiente.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Siguiente Codigo:";
            // 
            // tggEnable
            // 
            this.tggEnable.EditValue = true;
            this.tggEnable.Location = new System.Drawing.Point(42, 248);
            this.tggEnable.Name = "tggEnable";
            this.tggEnable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tggEnable.Properties.Appearance.Options.UseFont = true;
            this.tggEnable.Properties.OffText = "Off";
            this.tggEnable.Properties.OnText = "On";
            this.tggEnable.Size = new System.Drawing.Size(95, 24);
            this.tggEnable.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Habilitado:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(42, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(243, 26);
            this.txtCodigo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Codigo:";
            // 
            // dsAtributos1
            // 
            this.dsAtributos1.DataSetName = "dsAtributos";
            this.dsAtributos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grd_data
            // 
            this.grd_data.DataMember = "findAtributos";
            this.grd_data.DataSource = this.dsAtributos1;
            this.grd_data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.grd_data.Location = new System.Drawing.Point(1, 278);
            this.grd_data.MainView = this.grdv_data;
            this.grd_data.Name = "grd_data";
            this.grd_data.Size = new System.Drawing.Size(569, 343);
            this.grd_data.TabIndex = 35;
            this.grd_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv_data});
            // 
            // grdv_data
            // 
            this.grdv_data.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FocusedRow.Options.UseFont = true;
            this.grdv_data.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grdv_data.Appearance.FooterPanel.Options.UseFont = true;
            this.grdv_data.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colatributo,
            this.colSeleccionado,
            this.coleliminar,
            this.colTipoDato,
            this.colAddAtributo});
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
            this.colatributo.OptionsColumn.AllowEdit = false;
            this.colatributo.Visible = true;
            this.colatributo.VisibleIndex = 0;
            this.colatributo.Width = 374;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.FieldName = "seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 1;
            this.colSeleccionado.Width = 122;
            // 
            // coleliminar
            // 
            this.coleliminar.Caption = "Eliminar";
            this.coleliminar.Name = "coleliminar";
            // 
            // colTipoDato
            // 
            this.colTipoDato.FieldName = "tipoDato";
            this.colTipoDato.Name = "colTipoDato";
            // 
            // colAddAtributo
            // 
            this.colAddAtributo.Caption = "Agregar";
            this.colAddAtributo.Name = "colAddAtributo";
            // 
            // cmdRegistrarItem
            // 
            this.cmdRegistrarItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarItem.Appearance.Options.UseFont = true;
            this.cmdRegistrarItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarItem.ImageOptions.Image")));
            this.cmdRegistrarItem.Location = new System.Drawing.Point(96, 627);
            this.cmdRegistrarItem.Name = "cmdRegistrarItem";
            this.cmdRegistrarItem.Size = new System.Drawing.Size(198, 51);
            this.cmdRegistrarItem.TabIndex = 36;
            this.cmdRegistrarItem.Text = "REGISTRAR TIPO EQUIPO";
            this.cmdRegistrarItem.Click += new System.EventHandler(this.cmdRegistrarItem_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Appearance.Options.UseFont = true;
            this.cmdCerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.ImageOptions.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(300, 627);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(141, 51);
            this.cmdCerrar.TabIndex = 37;
            this.cmdCerrar.Text = "CERRAR";
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmTipoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 690);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdRegistrarItem);
            this.Controls.Add(this.grd_data);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tggEnable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionCompleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Name = "frmTipoEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Equipo";
            this.Load += new System.EventHandler(this.frmTipoEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCompleta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdSiguiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tggEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtributos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtDescripcionCompleta;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtIdSiguiente;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ToggleSwitch tggEnable;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private System.Windows.Forms.Label label3;
        private dsAtributos dsAtributos1;
        private DevExpress.XtraGrid.GridControl grd_data;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv_data;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colatributo;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn coleliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDato;
        private DevExpress.XtraEditors.SimpleButton cmdRegistrarItem;
        private DevExpress.XtraEditors.SimpleButton cmdCerrar;
        private DevExpress.XtraGrid.Columns.GridColumn colAddAtributo;
    }
}