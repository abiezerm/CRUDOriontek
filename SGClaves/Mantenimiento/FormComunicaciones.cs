using System;


using SGClaves.General;
using SGClaves.Presenter;
using Services;
using Entidad;
using System.Collections;
using SGClaves.Modelos;

namespace SGClaves
{
    public interface IComunicaciones : IView
    {

    }
    public partial class FormComunicaciones : FormBase, IComunicaciones
    {
        ComunicacionModel entidad;
        IComunicacionPresenter _presenter = new ComunicacionesPrensenter();
        public FormComunicaciones()
        {

            InitializeComponent();

        }

        private void FormComunicaciones_Load(object sender, EventArgs e)
        {
            gridControlComunicacion.DataSource = _presenter.Get();
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var entida = new Comunicacion();
                entida.Nombre = textEditComunicacion.Text;
                entida.Estatus = Convert.ToByte(checkBoxEstatus.CheckState);
                entida.FechaCreacion = DateTime.Now;
                _presenter.Add(entida);
                gridControlComunicacion.DataSource = _presenter.Get();
                MessageBox("Informacio", "Se Agrego el tipo de comunicacion correctamente.");
            }
            catch (Exception EX)
            {

                MessageBox("Error", EX.ToString());
            }
            
        }
        private void gridControlComunicacion_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonActualizar.Visible = true;
            if (gridViewComunicacion.SelectedRowsCount < 1) return;
            entidad = (ComunicacionModel)gridViewComunicacion.GetRow(gridViewComunicacion.GetSelectedRows()[0]);
            LoadComunicacion(entidad);
        }
        int id;

        private void LoadComunicacion(ComunicacionModel entidad)
        {
            id = entidad.IdComunicacion;
            textEditComunicacion.Text = entidad.Nombre;
            checkBoxEstatus.Checked = Convert.ToBoolean(entidad.Estatus);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var entida = new Comunicacion();
                entida.IdComunicacion = id;
                entida.Nombre = textEditComunicacion.Text;
                entida.Estatus = Convert.ToByte(checkBoxEstatus.CheckState);
                entida.FechaCreacion = DateTime.Now;

                _presenter.Update(entida);
                gridControlComunicacion.DataSource = _presenter.Get();
                MessageBox("Informacio", "Se Actualizo el tipo de comunicacion correctamente.");
            }
            catch (Exception ex)
            {


                MessageBox("Error", ex.ToString());
            }

        }
    }
}
