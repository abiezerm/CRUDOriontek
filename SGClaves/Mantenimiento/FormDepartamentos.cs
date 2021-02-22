using SGClaves.General;
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
    public interface IDepartamento : IView
    {

    }
    public partial class FormDepartamentos : FormBase
    {
        IDepartamentoPresenter _presenter = new DepartamentoPresenter();

        public FormDepartamentos()
        {
            InitializeComponent();
        }

        private void gridControlDepartamento_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FormDepartamentos_Load(object sender, EventArgs e)
        {
            gridControlDepartamento.DataSource = _presenter.Get();
        }
    }
}
