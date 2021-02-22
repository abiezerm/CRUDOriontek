namespace SGClaves
{
    partial class FormDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartamentos));
            this.gridControlDepartamento = new DevExpress.XtraGrid.GridControl();
            this.gridViewDepartamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEditDepartamento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDepartamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDepartamento
            // 
            this.gridControlDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDepartamento.Location = new System.Drawing.Point(12, 63);
            this.gridControlDepartamento.MainView = this.gridViewDepartamento;
            this.gridControlDepartamento.Name = "gridControlDepartamento";
            this.gridControlDepartamento.Size = new System.Drawing.Size(595, 309);
            this.gridControlDepartamento.TabIndex = 23;
            this.gridControlDepartamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepartamento});
            this.gridControlDepartamento.DoubleClick += new System.EventHandler(this.gridControlDepartamento_DoubleClick);
            // 
            // gridViewDepartamento
            // 
            this.gridViewDepartamento.GridControl = this.gridControlDepartamento;
            this.gridViewDepartamento.Name = "gridViewDepartamento";
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(195, 38);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 31;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEditDepartamento
            // 
            this.textEditDepartamento.Location = new System.Drawing.Point(92, 37);
            this.textEditDepartamento.Name = "textEditDepartamento";
            this.textEditDepartamento.Size = new System.Drawing.Size(100, 20);
            this.textEditDepartamento.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 14);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Departamento:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(89, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 28;
            this.simpleButton2.Text = "Actualizar";
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(8, 5);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 27;
            this.simpleButtonGuardar.Text = "Guardar";
            // 
            // FormDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 384);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditDepartamento);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Controls.Add(this.gridControlDepartamento);
            this.Name = "FormDepartamentos";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.FormDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDepartamento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDepartamento;
        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEditDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
    }
}