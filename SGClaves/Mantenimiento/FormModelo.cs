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
    public interface IModelo : IView
    {

    }
    public partial class FormModelo : FormBase
    {
        IModeloPresenter _imodeloPresenter = new ModeloPresenter();
        public FormModelo()
        {
            InitializeComponent();
        }

        private void FormModelo_Load(object sender, EventArgs e)
        {
            gridControlModelo.DataSource = _imodeloPresenter.Get();
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Modelo();
                entidad.Nombre = textEditModelo.Text;
                entidad.Estatus = Convert.ToByte(checkBoxEstatus.Checked);
                entidad.FechaCreacion = DateTime.Now;

                _imodeloPresenter.Add(entidad);
                gridControlModelo.DataSource = _imodeloPresenter.Get();
                MessageBox("Informacio", "Se Agrego el tipo de comunicacion correctamente.");
                textEditModelo.Text = string.Empty;
                checkBoxEstatus.Checked = false;
            }
            catch (Exception EX)
            {

                MessageBox("Error", EX.ToString());
            }
        }
        int id;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var entida = new Modelo();
                entida.IdModelo = id;
                entida.Nombre = textEditModelo.Text;
                entida.Estatus = Convert.ToByte(checkBoxEstatus.CheckState);
                entida.FechaCreacion = DateTime.Now;

                _imodeloPresenter.Update(entida);
                gridControlModelo.DataSource = _imodeloPresenter.Get();
                MessageBox("Informacio", "Se Actualizo el tipo de comunicacion correctamente.");
                textEditModelo.Text = string.Empty;
                checkBoxEstatus.Checked = false;
                id = 0;
                simpleButtonActualizar.Visible =false;
            }
            catch (Exception ex)
            {


                MessageBox("Error", ex.ToString());
            }
        }

        private void gridControlModelo_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonActualizar.Visible = true;
            if (gridViewModelo.SelectedRowsCount < 1) return;
            var entidad = (ModeloModel)gridViewModelo.GetRow(gridViewModelo.GetSelectedRows()[0]);
            LoadModelo(entidad);
        }
       
        void LoadModelo(ModeloModel item)
        {
            textEditModelo.Text = item.Nombre;
            checkBoxEstatus.Checked = Convert.ToBoolean(item.Estatus);
            id = item.IdModelo;
        }
    }
}
