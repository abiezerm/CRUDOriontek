namespace SGClaves
{
    partial class FormDescripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescripcion));
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEditDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDepartamento = new DevExpress.XtraGrid.GridControl();
            this.gridViewDepartamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(182, 38);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 36;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEditDescripcion
            // 
            this.textEditDescripcion.Location = new System.Drawing.Point(76, 37);
            this.textEditDescripcion.Name = "textEditDescripcion";
            this.textEditDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textEditDescripcion.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Descripcion:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(89, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 33;
            this.simpleButton2.Text = "Actualizar";
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(8, 5);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 32;
            this.simpleButtonGuardar.Text = "Guardar";
            // 
            // gridControlDepartamento
            // 
            this.gridControlDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlDepartamento.Location = new System.Drawing.Point(5, 63);
            this.gridControlDepartamento.MainView = this.gridViewDepartamento;
            this.gridControlDepartamento.Name = "gridControlDepartamento";
            this.gridControlDepartamento.Size = new System.Drawing.Size(562, 364);
            this.gridControlDepartamento.TabIndex = 37;
            this.gridControlDepartamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDepartamento});
            // 
            // gridViewDepartamento
            // 
            this.gridViewDepartamento.GridControl = this.gridControlDepartamento;
            this.gridViewDepartamento.Name = "gridViewDepartamento";
            // 
            // FormDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 439);
            this.Controls.Add(this.gridControlDepartamento);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditDescripcion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormDescripcion";
            this.Text = "Descripcion";
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEditDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraGrid.GridControl gridControlDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDepartamento;
    }
}