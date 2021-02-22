using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClaves
{
    public partial class FormMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMenu()
        {
            InitializeComponent();
         
        }
        private async void ShowWindowAsync<T>(BarButtonItem invoker) where T : Form
        {
            invoker.Enabled = false;
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var currentUICulture = Thread.CurrentThread.CurrentUICulture;
            var form = await Task<T>.Factory.StartNew(() =>
            {
                Thread.CurrentThread.CurrentCulture = currentCulture;
                Thread.CurrentThread.CurrentUICulture = currentUICulture;
                var a = Activator.CreateInstance<T>();
         
                return a;
            });
            invoker.Enabled = true;
            form.MdiParent = this;
            form.Show();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowWindowAsync<FormConfMedidor>(barButtonItem1);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItemCondicionTipo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormTipoCondicion>(barButtonItemCondicionTipo);
        }

        private void barButtonItemConsdicionesPrueba_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormTipoCondicionPrueba>(barButtonItemConsdicionesPrueba);
        }

        private void barButtonItemMarcas_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormMarca>(barButtonItemMarcas);
        }

        private void barButtonItemModelo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormModelo>(barButtonItemModelo);
        }

        private void barButtonItemComunicasion_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormComunicaciones>(barButtonItemComunicasion);
        }

        private void barButtonItemDepartamento_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormDepartamentos>(barButtonItemDepartamento);
        }

        private void barButtonItemDescripcion_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormDescripcion>(barButtonItemDescripcion);
        }

        private void barButtonItemRegistroOficina_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormDescripcion>(barButtonItemRegistroOficina);
        }

        private void barButtonItemValidacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormValidacion>(barButtonItemValidacion);
        }

        private void barButtonItemRegistroMedidor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWindowAsync<FormRegistroMedidor>(barButtonItemRegistroMedidor);
        }
    }
}
