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
    public interface IMedidor : IView
    {

    }

    public partial class FormConfMedidor : FormBase
    {
        IMedidorPresenter _presenter = new MedidorPresenter();
        public FormConfMedidor()
        {
            InitializeComponent();
        }

        private void FormConfMedidor_Load(object sender, EventArgs e)
        {
            gridControlConfiguMendidor.DataSource = _presenter.GetTipo();
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var entidad = new TipoMedidor();
                entidad.Nombre = textEditNombre.Text;
                entidad.tamano_clave = Convert.ToInt32(textEditClave.Text);
                entidad.Descripcion = textEditDescripcion.Text;
                if (checkBoxAsignar.Checked == true)
                {
                    entidad.Estatus = "Activo";
                }
                else
                {
                    entidad.Estatus = "Desactivado";
                }
                _presenter.Add(entidad);
                gridControlConfiguMendidor.DataSource = _presenter.GetTipo();
                MessageBox("Informacion", "Se agrago la configuracion satisfactoriamente");
            }
            catch (Exception ex)
            {

                MessageBox("Error", ex.ToString());
            }
            

        }

        private void simpleButtonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new TipoMedidor();
            entidad.Nombre = textEditNombre.Text;
            entidad.tamano_clave = Convert.ToInt32(textEditClave.Text);
            entidad.Descripcion = textEditDescripcion.Text;
            entidad.IDtipomedidor = id;
            if (checkBoxAsignar.Checked == true)
            {
                entidad.Estatus = "Activo";
            }
            else
            {
                entidad.Estatus = "Desactivado";
            }
            _presenter.Update(entidad);
            gridControlConfiguMendidor.DataSource = _presenter.GetTipo();
            MessageBox("Informacion", "Se actualizo la configuracion satisfactoriamente");
        }
            catch (Exception ex)
            {

                MessageBox("Error", ex.ToString());
            }
}

        int id;
        void loadmedidor(TipoMedidorModel item)
        {
            textEditClave.Text = item.Tamaño_Clave.ToString();
            textEditDescripcion.Text = item.Descripcion;
            textEditNombre.Text = item.Nombre;
            if (item.Estatus == "Activo" || item.Estatus == "ACTIVO")
            {
                checkBoxAsignar.Checked = true;
            }
            else
            {
                checkBoxAsignar.Checked = false;
            }

            id = item.IdTipoMedidor;
        }

        private void simpleButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var entidad = new TipoMedidor();
                entidad.Nombre = textEditNombre.Text;
                entidad.tamano_clave = Convert.ToInt32(textEditClave.Text);
                entidad.Descripcion = textEditDescripcion.Text;
                entidad.IDtipomedidor = id;
                if (checkBoxAsignar.Checked == true)
                {
                    entidad.Estatus = "Activo";
                }
                else
                {
                    entidad.Estatus = "Desactivado";
                }

                _presenter.DeleteTipo(entidad);
                gridControlConfiguMendidor.DataSource = _presenter.GetTipo();
                MessageBox("Informacion", "Se elimino la configuracion satisfactoriamente");
            }
            catch (Exception ex)
            {

                MessageBox("Error", ex.ToString());
            }
          
        }

        private void gridControlConfiguMendidor_DoubleClick_1(object sender, EventArgs e)
        {
            simpleButtonEliminar.Visible = true;
            simpleButtonActualizar.Visible = true;
            if (gridViewConfiguMendidor.SelectedRowsCount < 1) return;
            var entidad = (TipoMedidorModel)gridViewConfiguMendidor.GetRow(gridViewConfiguMendidor.GetSelectedRows()[0]);
            loadmedidor(entidad);
        }
    }
}
