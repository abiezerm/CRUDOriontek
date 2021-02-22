namespace SGClaves
{
    partial class FormValidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidacion));
            this.gridControlValidacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewValidacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlValidacion
            // 
            this.gridControlValidacion.Location = new System.Drawing.Point(12, 54);
            this.gridControlValidacion.MainView = this.gridViewValidacion;
            this.gridControlValidacion.Name = "gridControlValidacion";
            this.gridControlValidacion.Size = new System.Drawing.Size(608, 335);
            this.gridControlValidacion.TabIndex = 0;
            this.gridControlValidacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewValidacion});
            // 
            // gridViewValidacion
            // 
            this.gridViewValidacion.GridControl = this.gridControlValidacion;
            this.gridViewValidacion.Name = "gridViewValidacion";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Validar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(91, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Copiar";
            // 
            // FormValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 401);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControlValidacion);
            this.Name = "FormValidacion";
            this.Text = "Validacion";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlValidacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewValidacion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}