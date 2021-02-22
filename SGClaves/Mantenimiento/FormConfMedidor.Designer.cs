namespace SGClaves
{
    partial class FormConfMedidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfMedidor));
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.textEditClave = new DevExpress.XtraEditors.TextEdit();
            this.textEditNombre = new DevExpress.XtraEditors.TextEdit();
            this.checkBoxAsignar = new System.Windows.Forms.CheckBox();
            this.simpleButtonActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlConfiguMendidor = new DevExpress.XtraGrid.GridControl();
            this.gridViewConfiguMendidor = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConfiguMendidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConfiguMendidor)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGuardar.Image")));
            this.simpleButtonGuardar.Location = new System.Drawing.Point(12, 3);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonGuardar.TabIndex = 1;
            this.simpleButtonGuardar.Text = "Guardar";
            this.simpleButtonGuardar.Click += new System.EventHandler(this.simpleButtonGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(22, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nombre:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(8, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Descripción:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(209, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tamaño de Clave:";
            // 
            // textEditDescripcion
            // 
            this.textEditDescripcion.Location = new System.Drawing.Point(89, 71);
            this.textEditDescripcion.Name = "textEditDescripcion";
            this.textEditDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textEditDescripcion.TabIndex = 7;
            // 
            // textEditClave
            // 
            this.textEditClave.Location = new System.Drawing.Point(322, 74);
            this.textEditClave.Name = "textEditClave";
            this.textEditClave.Size = new System.Drawing.Size(100, 20);
            this.textEditClave.TabIndex = 8;
            // 
            // textEditNombre
            // 
            this.textEditNombre.Location = new System.Drawing.Point(89, 42);
            this.textEditNombre.Name = "textEditNombre";
            this.textEditNombre.Size = new System.Drawing.Size(100, 20);
            this.textEditNombre.TabIndex = 9;
            // 
            // checkBoxAsignar
            // 
            this.checkBoxAsignar.AutoSize = true;
            this.checkBoxAsignar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAsignar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAsignar.Location = new System.Drawing.Point(206, 44);
            this.checkBoxAsignar.Name = "checkBoxAsignar";
            this.checkBoxAsignar.Size = new System.Drawing.Size(101, 18);
            this.checkBoxAsignar.TabIndex = 10;
            this.checkBoxAsignar.Text = "Asignar Clave:";
            this.checkBoxAsignar.UseVisualStyleBackColor = true;
            // 
            // simpleButtonActualizar
            // 
            this.simpleButtonActualizar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualizar.Image")));
            this.simpleButtonActualizar.Location = new System.Drawing.Point(93, 3);
            this.simpleButtonActualizar.Name = "simpleButtonActualizar";
            this.simpleButtonActualizar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonActualizar.TabIndex = 11;
            this.simpleButtonActualizar.Text = "Actualizar";
            this.simpleButtonActualizar.Visible = false;
            this.simpleButtonActualizar.Click += new System.EventHandler(this.simpleButtonActualizar_Click);
            // 
            // simpleButtonEliminar
            // 
            this.simpleButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonEliminar.Image")));
            this.simpleButtonEliminar.Location = new System.Drawing.Point(174, 3);
            this.simpleButtonEliminar.Name = "simpleButtonEliminar";
            this.simpleButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEliminar.TabIndex = 12;
            this.simpleButtonEliminar.Text = "Eliminar";
            this.simpleButtonEliminar.Visible = false;
            this.simpleButtonEliminar.Click += new System.EventHandler(this.simpleButtonEliminar_Click);
            // 
            // gridControlConfiguMendidor
            // 
            this.gridControlConfiguMendidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlConfiguMendidor.Location = new System.Drawing.Point(0, 115);
            this.gridControlConfiguMendidor.MainView = this.gridViewConfiguMendidor;
            this.gridControlConfiguMendidor.Name = "gridControlConfiguMendidor";
            this.gridControlConfiguMendidor.Size = new System.Drawing.Size(775, 328);
            this.gridControlConfiguMendidor.TabIndex = 13;
            this.gridControlConfiguMendidor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConfiguMendidor});
            this.gridControlConfiguMendidor.DoubleClick += new System.EventHandler(this.gridControlConfiguMendidor_DoubleClick_1);
            // 
            // gridViewConfiguMendidor
            // 
            this.gridViewConfiguMendidor.GridControl = this.gridControlConfiguMendidor;
            this.gridViewConfiguMendidor.Name = "gridViewConfiguMendidor";
            this.gridViewConfiguMendidor.OptionsBehavior.Editable = false;
            this.gridViewConfiguMendidor.OptionsFind.AlwaysVisible = true;
            this.gridViewConfiguMendidor.OptionsFind.FindNullPrompt = "Buscar...";
            // 
            // FormConfMedidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 446);
            this.Controls.Add(this.gridControlConfiguMendidor);
            this.Controls.Add(this.simpleButtonEliminar);
            this.Controls.Add(this.simpleButtonActualizar);
            this.Controls.Add(this.checkBoxAsignar);
            this.Controls.Add(this.textEditNombre);
            this.Controls.Add(this.textEditClave);
            this.Controls.Add(this.textEditDescripcion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButtonGuardar);
            this.Name = "FormConfMedidor";
            this.Text = "Configuracion de Medidores";
            this.Load += new System.EventHandler(this.FormConfMedidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConfiguMendidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConfiguMendidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditDescripcion;
        private DevExpress.XtraEditors.TextEdit textEditClave;
        private DevExpress.XtraEditors.TextEdit textEditNombre;
        private System.Windows.Forms.CheckBox checkBoxAsignar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonActualizar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEliminar;
        private DevExpress.XtraGrid.GridControl gridControlConfiguMendidor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConfiguMendidor;
    }
}