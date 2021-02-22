namespace SGClaves
{
    partial class FormModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModelo));
            this.checkBoxEstatus = new System.Windows.Forms.CheckBox();
            this.textEditModelo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlModelo = new DevExpress.XtraGrid.GridControl();
            this.gridViewModelo = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEstatus
            // 
            this.checkBoxEstatus.AutoSize = true;
            this.checkBoxEstatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatus.Location = new System.Drawing.Point(161, 38);
            this.checkBoxEstatus.Name = "checkBoxEstatus";
            this.checkBoxEstatus.Size = new System.Drawing.Size(66, 18);
            this.checkBoxEstatus.TabIndex = 21;
            this.checkBoxEstatus.Text = "Estatus";
            this.checkBoxEstatus.UseVisualStyleBackColor = true;
            // 
            // textEditModelo
            // 
            this.textEditModelo.Location = new System.Drawing.Point(55, 37);
            this.textEditModelo.Name = "textEditModelo";
            this.textEditModelo.Size = new System.Drawing.Size(100, 20);
            this.textEditModelo.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 14);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Modelo:";
            // 
            // simpleButtonActualizar
            // 
            this.simpleButtonActualizar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.Image")));
            this.simpleButtonActualizar.Location = new System.Drawing.Point(89, 5);
            this.simpleButtonActualizar.Name = "simpleButtonActualizar";
            this.simpleButtonActualizar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonActualizar.TabIndex = 18;
            this.simpleButtonActualizar.Text = "Actualizar";
            this.simpleButtonActualizar.Visible = false;
            this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(8, 5);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 17;
            this.simpleButtonGuardar.Text = "Guardar";
            this.simpleButtonGuardar.Click += new System.EventHandler(this.simpleButtonGuardar_Click);
            // 
            // gridControlModelo
            // 
            this.gridControlModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlModelo.Location = new System.Drawing.Point(5, 62);
            this.gridControlModelo.MainView = this.gridViewModelo;
            this.gridControlModelo.Name = "gridControlModelo";
            this.gridControlModelo.Size = new System.Drawing.Size(746, 356);
            this.gridControlModelo.TabIndex = 22;
            this.gridControlModelo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewModelo});
            this.gridControlModelo.DoubleClick += new System.EventHandler(this.gridControlModelo_DoubleClick);
            // 
            // gridViewModelo
            // 
            this.gridViewModelo.GridControl = this.gridControlModelo;
            this.gridViewModelo.Name = "gridViewModelo";
            this.gridViewModelo.OptionsBehavior.Editable = false;
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 430);
            this.Controls.Add(this.gridControlModelo);
            this.Controls.Add(this.checkBoxEstatus);
            this.Controls.Add(this.textEditModelo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButtonActualizar);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.FormModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEstatus;
        private DevExpress.XtraEditors.TextEdit textEditModelo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraGrid.GridControl gridControlModelo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewModelo;
    }
}