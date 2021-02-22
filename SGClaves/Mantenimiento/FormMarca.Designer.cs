namespace SGClaves
{
    partial class FormMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarca));
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEditMarca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMarcas = new DevExpress.XtraGrid.GridControl();
            this.gridViewMarcas = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(160, 38);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 16;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEditMarca
            // 
            this.textEditMarca.Location = new System.Drawing.Point(54, 37);
            this.textEditMarca.Name = "textEditMarca";
            this.textEditMarca.Size = new System.Drawing.Size(100, 20);
            this.textEditMarca.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(4, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 14);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Marca:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(88, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Actualizar";
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(7, 5);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 12;
            this.simpleButtonGuardar.Text = "Guardar";
            // 
            // gridControlMarcas
            // 
            this.gridControlMarcas.Location = new System.Drawing.Point(4, 63);
            this.gridControlMarcas.MainView = this.gridViewMarcas;
            this.gridControlMarcas.Name = "gridControlMarcas";
            this.gridControlMarcas.Size = new System.Drawing.Size(674, 348);
            this.gridControlMarcas.TabIndex = 17;
            this.gridControlMarcas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMarcas});
            // 
            // gridViewMarcas
            // 
            this.gridViewMarcas.GridControl = this.gridControlMarcas;
            this.gridViewMarcas.Name = "gridViewMarcas";
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 414);
            this.Controls.Add(this.gridControlMarcas);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditMarca);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormMarca";
            this.Text = "Marca";
            ((System.ComponentModel.ISupportInitialize)(this.textEditMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEditMarca;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraGrid.GridControl gridControlMarcas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarcas;
    }
}