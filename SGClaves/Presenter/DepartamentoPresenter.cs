using Entidad;
using Services;
using SGClaves.General;
using SGClaves.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Presenter
{
    public interface IDepartamentoPresenter: IPresenter<IDepartamento>
    {
        void Add(Departamento item);
        void Update(Departamento item);
        void Delete(Departamento item);
        IEnumerable<DepartamentoModel> Get();
    }
    public class DepartamentoPresenter : PresenterBase, IDepartamentoPresenter
    {

        public IDepartamento View
        {
            get;

            set;
        }

        public event CompletedOperationDelegate CompleteEvent;

        public void Add(Departamento item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Departamento item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartamentoModel> Get()
        {


            throw new NotImplementedException();
        }

        public void Update(Departamento item)
        {
            throw new NotImplementedException();
        }
    }
}
