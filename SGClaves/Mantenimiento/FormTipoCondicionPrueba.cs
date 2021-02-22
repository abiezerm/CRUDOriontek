using Entidad;
using SGClaves.General;
using SGClaves.Modelos;
using SGClaves.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClaves
{
    public interface ICondicionPrueba : IView
    {

    }
    public partial class FormTipoCondicionPrueba : FormBase
    {
        ICondicionPruebaPresenter _icndicionPruebaPresenter = new CondicionPruebaPresenter();
        public FormTipoCondicionPrueba()
        {
            InitializeComponent();
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new CondicionPrueba();
                entidad.Descripcion = textEdit1.Text;
                entidad.Estatus = Convert.ToByte(checkBoxEstatus.Checked);
                entidad.FechaCreacion = DateTime.Now;
                _icndicionPruebaPresenter.Add(entidad);
                gridControlTipoCondicionPrueba.DataSource = _icndicionPruebaPresenter.Get();
                MessageBox("Informacion", "Se agrego el registro satisfactoriamente.");
                textEdit1.Text = string.Empty;
                checkBoxEstatus.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox("Error", ex.ToString());
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new CondicionPrueba();
                entidad.Descripcion = textEdit1.Text;
                entidad.Estatus = Convert.ToByte(checkBoxEstatus.Checked);
                entidad.FechaCreacion = DateTime.Now;
                entidad.IdCondicionPrueba = id;
                _icndicionPruebaPresenter.Update(entidad);
                gridControlTipoCondicionPrueba.DataSource = _icndicionPruebaPresenter.Get();
                MessageBox("Informacion", "Se actualizo el registro satisfactoriamente.");
                textEdit1.Text = string.Empty;
                checkBoxEstatus.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox("Error", ex.ToString());
            }
    
        }

        private void gridControlTipoCondicionPrueba_DoubleClick(object sender, EventArgs e)
        {
            simpleButton2.Visible = true;
            if (gridViewTipoCondicionPrueba.SelectedRowsCount < 1) return;
            var entidad = (CondicionPruebaModel)gridViewTipoCondicionPrueba.GetRow(gridViewTipoCondicionPrueba.GetSelectedRows()[0]);

            LoadCondicionPrueba(entidad);
        }
        int id;
        void LoadCondicionPrueba(CondicionPruebaModel iten)
        {
            textEdit1.Text = iten.Descripcion;
            checkBoxEstatus.Checked = Convert.ToBoolean(iten.Estatus);
            id = iten.IdCondicionPrueba;
        }

        private void FormTipoCondicionPrueba_Load(object sender, EventArgs e)
        {
            gridControlTipoCondicionPrueba.DataSource = _icndicionPruebaPresenter.Get();
        }
    }
}
