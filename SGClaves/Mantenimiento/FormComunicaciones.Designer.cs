namespace SGClaves
{
    partial class FormComunicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComunicaciones));
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEditComunicacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlComunicacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewComunicacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditComunicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComunicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComunicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(193, 38);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 26;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEditComunicacion
            // 
            this.textEditComunicacion.Location = new System.Drawing.Point(87, 37);
            this.textEditComunicacion.Name = "textEditComunicacion";
            this.textEditComunicacion.Size = new System.Drawing.Size(100, 20);
            this.textEditComunicacion.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(3, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 14);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Comunicacion:";
            // 
            // simpleButtonActualizar
            // 
            this.simpleButtonActualizar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.Image")));
            this.simpleButtonActualizar.Location = new System.Drawing.Point(87, 5);
            this.simpleButtonActualizar.Name = "simpleButtonActualizar";
            this.simpleButtonActualizar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonActualizar.TabIndex = 23;
            this.simpleButtonActualizar.Text = "Actualizar";
            this.simpleButtonActualizar.Visible = false;
            this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(6, 5);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 22;
            this.simpleButtonGuardar.Text = "Guardar";
            this.simpleButtonGuardar.Click += new System.EventHandler(this.simpleButtonGuardar_Click);
            // 
            // gridControlComunicacion
            // 
            this.gridControlComunicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlComunicacion.Location = new System.Drawing.Point(3, 63);
            this.gridControlComunicacion.MainView = this.gridViewComunicacion;
            this.gridControlComunicacion.Name = "gridControlComunicacion";
            this.gridControlComunicacion.Size = new System.Drawing.Size(712, 351);
            this.gridControlComunicacion.TabIndex = 27;
            this.gridControlComunicacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComunicacion});
            this.gridControlComunicacion.DoubleClick += new System.EventHandler(this.gridControlComunicacion_DoubleClick);
            // 
            // gridViewComunicacion
            // 
            this.gridViewComunicacion.GridControl = this.gridControlComunicacion;
            this.gridViewComunicacion.Name = "gridViewComunicacion";
            this.gridViewComunicacion.OptionsBehavior.Editable = false;
            // 
            // FormComunicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 417);
            this.Controls.Add(this.gridControlComunicacion);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditComunicacion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButtonActualizar);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormComunicaciones";
            this.Text = "Comunicaciones";
            this.Load += new System.EventHandler(this.FormComunicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditComunicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComunicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComunicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEditComunicacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraGrid.GridControl gridControlComunicacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComunicacion;
    }
}