namespace SGClaves
{
    partial class FormTipoCondicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoCondicion));
            this.gridControlTipoCondicion = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoCondicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNombre = new DevExpress.XtraEditors.TextEdit();
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCondicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCondicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlTipoCondicion
            // 
            this.gridControlTipoCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTipoCondicion.Location = new System.Drawing.Point(3, 69);
            this.gridControlTipoCondicion.MainView = this.gridViewTipoCondicion;
            this.gridControlTipoCondicion.Name = "gridControlTipoCondicion";
            this.gridControlTipoCondicion.Size = new System.Drawing.Size(683, 323);
            this.gridControlTipoCondicion.TabIndex = 0;
            this.gridControlTipoCondicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoCondicion});
            this.gridControlTipoCondicion.DoubleClick += new System.EventHandler(this.gridControlTipoCondicion_DoubleClick);
            // 
            // gridViewTipoCondicion
            // 
            this.gridViewTipoCondicion.GridControl = this.gridControlTipoCondicion;
            this.gridViewTipoCondicion.Name = "gridViewTipoCondicion";
            this.gridViewTipoCondicion.OptionsBehavior.Editable = false;
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(12, 7);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 1;
            this.simpleButtonGuardar.Text = "Guardar";
            this.simpleButtonGuardar.Click += new System.EventHandler(this.simpleButtonGuardar_Click);
            // 
            // simpleButtonActualizar
            // 
            this.simpleButtonActualizar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.Image")));
            this.simpleButtonActualizar.Location = new System.Drawing.Point(93, 9);
            this.simpleButtonActualizar.Name = "simpleButtonActualizar";
            this.simpleButtonActualizar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonActualizar.TabIndex = 2;
            this.simpleButtonActualizar.Text = "Actualizar";
            this.simpleButtonActualizar.Visible = false;
            this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(9, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tipo de Condicion:";
            // 
            // textEditNombre
            // 
            this.textEditNombre.Location = new System.Drawing.Point(117, 43);
            this.textEditNombre.Name = "textEditNombre";
            this.textEditNombre.Size = new System.Drawing.Size(100, 20);
            this.textEditNombre.TabIndex = 4;
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(224, 44);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 5;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // FormTipoCondicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 404);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditNombre);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButtonActualizar);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Controls.Add(this.gridControlTipoCondicion);
            this.Name = "FormTipoCondicion";
            this.Text = "Tipo Condicion";
            this.Load += new System.EventHandler(this.FormTipoCondicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCondicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCondicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTipoCondicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoCondicion;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditNombre;
        private System.Windows.Forms.CheckBox checkBoxEstatus;
    }
}