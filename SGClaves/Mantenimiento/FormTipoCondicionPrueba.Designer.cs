namespace SGClaves
{
    partial class FormTipoCondicionPrueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoCondicionPrueba));
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTipoCondicionPrueba = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoCondicionPrueba = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCondicionPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCondicionPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(221, 38);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 11;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(114, 37);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tipo de Condicion:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(90, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Actualizar";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(9, 6);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 7;
            this.simpleButtonGuardar.Text = "Guardar";
            this.simpleButtonGuardar.Click += new System.EventHandler(this.simpleButtonGuardar_Click);
            // 
            // gridControlTipoCondicionPrueba
            // 
            this.gridControlTipoCondicionPrueba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlTipoCondicionPrueba.Location = new System.Drawing.Point(9, 72);
            this.gridControlTipoCondicionPrueba.MainView = this.gridViewTipoCondicionPrueba;
            this.gridControlTipoCondicionPrueba.Name = "gridControlTipoCondicionPrueba";
            this.gridControlTipoCondicionPrueba.Size = new System.Drawing.Size(708, 348);
            this.gridControlTipoCondicionPrueba.TabIndex = 12;
            this.gridControlTipoCondicionPrueba.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoCondicionPrueba});
            this.gridControlTipoCondicionPrueba.DoubleClick += new System.EventHandler(this.gridControlTipoCondicionPrueba_DoubleClick);
            // 
            // gridViewTipoCondicionPrueba
            // 
            this.gridViewTipoCondicionPrueba.GridControl = this.gridControlTipoCondicionPrueba;
            this.gridViewTipoCondicionPrueba.Name = "gridViewTipoCondicionPrueba";
            this.gridViewTipoCondicionPrueba.OptionsBehavior.Editable = false;
            // 
            // FormTipoCondicionPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 432);
            this.Controls.Add(this.gridControlTipoCondicionPrueba);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormTipoCondicionPrueba";
            this.Text = "Tipo Condicion Prueba";
            this.Load += new System.EventHandler(this.FormTipoCondicionPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCondicionPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCondicionPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraGrid.GridControl gridControlTipoCondicionPrueba;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoCondicionPrueba;
    }
}