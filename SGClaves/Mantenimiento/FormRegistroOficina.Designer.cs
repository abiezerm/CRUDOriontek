namespace SGClaves
{
    partial class FormRegistroOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroOficina));
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEditDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlRegistroOficina = new DevExpress.XtraGrid.GridControl();
            this.gridViewRegistroOficina = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegistroOficina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistroOficina)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(391, 33);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 41;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEditDescripcion
            // 
            this.textEditDescripcion.Location = new System.Drawing.Point(119, 31);
            this.textEditDescripcion.Name = "textEditDescripcion";
            this.textEditDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textEditDescripcion.TabIndex = 40;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(8, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 14);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Nombre de Oficina:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(84, 1);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 38;
            this.simpleButton2.Text = "Actualizar";
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(3, 1);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 37;
            this.simpleButtonGuardar.Text = "Guardar";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(285, 32);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 43;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(228, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 14);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "IdOficina:";
            // 
            // gridControlRegistroOficina
            // 
            this.gridControlRegistroOficina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlRegistroOficina.Location = new System.Drawing.Point(3, 58);
            this.gridControlRegistroOficina.MainView = this.gridViewRegistroOficina;
            this.gridControlRegistroOficina.Name = "gridControlRegistroOficina";
            this.gridControlRegistroOficina.Size = new System.Drawing.Size(647, 430);
            this.gridControlRegistroOficina.TabIndex = 44;
            this.gridControlRegistroOficina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRegistroOficina});
            // 
            // gridViewRegistroOficina
            // 
            this.gridViewRegistroOficina.GridControl = this.gridControlRegistroOficina;
            this.gridViewRegistroOficina.Name = "gridViewRegistroOficina";
            // 
            // FormRegistroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 490);
            this.Controls.Add(this.gridControlRegistroOficina);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditDescripcion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormRegistroOficina";
            this.Text = "Registro Oficina";
            this.Load += new System.EventHandler(this.FormRegistroOficina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRegistroOficina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistroOficina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEditDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlRegistroOficina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRegistroOficina;
    }
}