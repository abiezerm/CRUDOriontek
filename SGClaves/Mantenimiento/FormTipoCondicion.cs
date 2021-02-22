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
    public interface ICondicion : IView
    {

    }
    public partial class FormTipoCondicion : FormBase
    {
        ICondicionPresenter _icondicionPrsenter = new CondicionPresenter();
        public FormTipoCondicion()
        {
            InitializeComponent();
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new Condicion();
                entidad.Nombre = textEditNombre.Text;
                entidad.Estatus = Convert.ToByte(checkBoxEstatus.Checked);
                entidad.FechaCreacion = DateTime.Now;

                _icondicionPrsenter.Add(entidad);

                MessageBox("Informacion", "Se agrego el registro.");
                textEditNombre.Text = string.Empty;
                checkBoxEstatus.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox("Error", ex.ToString());

            }
            
        }

        private void gridControlTipoCondicion_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonActualizar.Visible = true;
            if (gridViewTipoCondicion.SelectedRowsCount < 1) return;
            var entidad =( CondicionModel )gridViewTipoCondicion.GetRow(gridViewTipoCondicion.GetSelectedRows()[0]);
            LoadCondicion(entidad);
        }
        int id;
        void LoadCondicion(CondicionModel item)
        {
            textEditNombre.Text = item.Nombre;
            checkBoxEstatus.Checked = Convert.ToBoolean(item.Estatus);
            id = item.IdCondicion;
        }

        private void simpleButtonActualizar_Click(object sender, EventArgs e)
        {
            try { 
            var entidad = new Condicion();
            entidad.Nombre = textEditNombre.Text;
            entidad.Estatus = Convert.ToByte(checkBoxEstatus.Checked);
            entidad.FechaCreacion = DateTime.Now;
            entidad.IdCondicion = id;
            _icondicionPrsenter.Update(entidad);
            MessageBox("Informacion", "Se actualizo el registro.");
            textEditNombre.Text = string.Empty;
            checkBoxEstatus.Checked = false;
            id = 0;
                gridControlTipoCondicion.DataSource = _icondicionPrsenter.Get();
                }
            catch (Exception ex)
            {
                MessageBox("Error", ex.ToString());

            }
}

        private void FormTipoCondicion_Load(object sender, EventArgs e)
        {
            gridControlTipoCondicion.DataSource = _icondicionPrsenter.Get();
        }
    }
}
