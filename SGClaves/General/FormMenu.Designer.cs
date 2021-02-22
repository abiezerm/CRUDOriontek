namespace SGClaves
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCondicionTipo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemConsdicionesPrueba = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMarcas = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModelo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemComunicasion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDepartamento = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDescripcion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRegistroOficina = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGeneracionClave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemValidacion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRegistroMedidor = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMaantenimientos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItemCondicionTipo,
            this.barButtonItemConsdicionesPrueba,
            this.barButtonItemMarcas,
            this.barButtonItemModelo,
            this.barButtonItemComunicasion,
            this.barButtonItemDepartamento,
            this.barButtonItemDescripcion,
            this.barButtonItemRegistroOficina,
            this.barButtonItemGeneracionClave,
            this.barButtonItemValidacion,
            this.barButtonItemRegistroMedidor});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMaantenimientos});
            this.ribbonControl1.Size = new System.Drawing.Size(958, 143);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Confihuacion de Medidor";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItemCondicionTipo
            // 
            this.barButtonItemCondicionTipo.Caption = "Tipos de Pruebas";
            this.barButtonItemCondicionTipo.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemCondicionTipo.Glyph")));
            this.barButtonItemCondicionTipo.Id = 2;
            this.barButtonItemCondicionTipo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemCondicionTipo.LargeGlyph")));
            this.barButtonItemCondicionTipo.Name = "barButtonItemCondicionTipo";
            this.barButtonItemCondicionTipo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCondicionTipo_ItemClick);
            // 
            // barButtonItemConsdicionesPrueba
            // 
            this.barButtonItemConsdicionesPrueba.Caption = "Tipo Condiciones Prueba";
            this.barButtonItemConsdicionesPrueba.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemConsdicionesPrueba.Glyph")));
            this.barButtonItemConsdicionesPrueba.Id = 3;
            this.barButtonItemConsdicionesPrueba.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemConsdicionesPrueba.LargeGlyph")));
            this.barButtonItemConsdicionesPrueba.Name = "barButtonItemConsdicionesPrueba";
            this.barButtonItemConsdicionesPrueba.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemConsdicionesPrueba_ItemClick);
            // 
            // barButtonItemMarcas
            // 
            this.barButtonItemMarcas.Caption = "Marcas";
            this.barButtonItemMarcas.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemMarcas.Glyph")));
            this.barButtonItemMarcas.Id = 4;
            this.barButtonItemMarcas.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemMarcas.LargeGlyph")));
            this.barButtonItemMarcas.Name = "barButtonItemMarcas";
            this.barButtonItemMarcas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMarcas_ItemClick);
            // 
            // barButtonItemModelo
            // 
            this.barButtonItemModelo.Caption = "Modelo";
            this.barButtonItemModelo.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemModelo.Glyph")));
            this.barButtonItemModelo.Id = 5;
            this.barButtonItemModelo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemModelo.LargeGlyph")));
            this.barButtonItemModelo.Name = "barButtonItemModelo";
            this.barButtonItemModelo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModelo_ItemClick);
            // 
            // barButtonItemComunicasion
            // 
            this.barButtonItemComunicasion.Caption = "Comunicasion";
            this.barButtonItemComunicasion.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemComunicasion.Glyph")));
            this.barButtonItemComunicasion.Id = 6;
            this.barButtonItemComunicasion.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemComunicasion.LargeGlyph")));
            this.barButtonItemComunicasion.Name = "barButtonItemComunicasion";
            this.barButtonItemComunicasion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemComunicasion_ItemClick);
            // 
            // barButtonItemDepartamento
            // 
            this.barButtonItemDepartamento.Caption = "Departamento";
            this.barButtonItemDepartamento.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDepartamento.Glyph")));
            this.barButtonItemDepartamento.Id = 7;
            this.barButtonItemDepartamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDepartamento.LargeGlyph")));
            this.barButtonItemDepartamento.Name = "barButtonItemDepartamento";
            this.barButtonItemDepartamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDepartamento_ItemClick);
            // 
            // barButtonItemDescripcion
            // 
            this.barButtonItemDescripcion.Caption = "Descripcion";
            this.barButtonItemDescripcion.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDescripcion.Glyph")));
            this.barButtonItemDescripcion.Id = 8;
            this.barButtonItemDescripcion.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDescripcion.LargeGlyph")));
            this.barButtonItemDescripcion.Name = "barButtonItemDescripcion";
            this.barButtonItemDescripcion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDescripcion_ItemClick);
            // 
            // barButtonItemRegistroOficina
            // 
            this.barButtonItemRegistroOficina.Caption = "Registro Oficina";
            this.barButtonItemRegistroOficina.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemRegistroOficina.Glyph")));
            this.barButtonItemRegistroOficina.Id = 9;
            this.barButtonItemRegistroOficina.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemRegistroOficina.LargeGlyph")));
            this.barButtonItemRegistroOficina.Name = "barButtonItemRegistroOficina";
            this.barButtonItemRegistroOficina.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRegistroOficina_ItemClick);
            // 
            // barButtonItemGeneracionClave
            // 
            this.barButtonItemGeneracionClave.Caption = "Generar Clave";
            this.barButtonItemGeneracionClave.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemGeneracionClave.Glyph")));
            this.barButtonItemGeneracionClave.Id = 10;
            this.barButtonItemGeneracionClave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemGeneracionClave.LargeGlyph")));
            this.barButtonItemGeneracionClave.Name = "barButtonItemGeneracionClave";
            // 
            // barButtonItemValidacion
            // 
            this.barButtonItemValidacion.Caption = "Validacion de Clave";
            this.barButtonItemValidacion.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemValidacion.Glyph")));
            this.barButtonItemValidacion.Id = 11;
            this.barButtonItemValidacion.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemValidacion.LargeGlyph")));
            this.barButtonItemValidacion.Name = "barButtonItemValidacion";
            this.barButtonItemValidacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemValidacion_ItemClick);
            // 
            // barButtonItemRegistroMedidor
            // 
            this.barButtonItemRegistroMedidor.Caption = "Registro de Medidor";
            this.barButtonItemRegistroMedidor.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemRegistroMedidor.Glyph")));
            this.barButtonItemRegistroMedidor.Id = 12;
            this.barButtonItemRegistroMedidor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemRegistroMedidor.LargeGlyph")));
            this.barButtonItemRegistroMedidor.Name = "barButtonItemRegistroMedidor";
            this.barButtonItemRegistroMedidor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRegistroMedidor_ItemClick);
            // 
            // ribbonPageMaantenimientos
            // 
            this.ribbonPageMaantenimientos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPageMaantenimientos.Name = "ribbonPageMaantenimientos";
            this.ribbonPageMaantenimientos.Text = "Mantenimientos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemComunicasion);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDescripcion);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDepartamento);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemMarcas);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemModelo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRegistroOficina);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemRegistroMedidor);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemCondicionTipo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemConsdicionesPrueba);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Mantenimiento";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemGeneracionClave);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemValidacion);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Funcionalidades";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((DevExpress.XtraTab.TabButtons.Close | DevExpress.XtraTab.TabButtons.Default)));
            this.xtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 469);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMaantenimientos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCondicionTipo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemConsdicionesPrueba;
        private DevExpress.XtraBars.BarButtonItem barButtonItemMarcas;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModelo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemComunicasion;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDepartamento;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDescripcion;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRegistroOficina;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGeneracionClave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemValidacion;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRegistroMedidor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}