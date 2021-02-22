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
    public interface ICondicionPresenter : IPresenter<ICondicion>
    {
        void Add(Condicion item);
        void Update(Condicion item);
        void Delete(Condicion item);
        IEnumerable<CondicionModel> Get();
    }
    public class CondicionPresenter : PresenterBase, ICondicionPresenter
    {
        ICondicionServices _icondicionServices = new CondicionServices();
        public ICondicion View
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event CompletedOperationDelegate CompleteEvent;

        public void Add(Condicion item)
        {
            _icondicionServices.Add(item);
        }

        public void Delete(Condicion item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CondicionModel> Get()
        {
            var condicion = _icondicionServices.Get();
            return condicion.Select(CondicionModel.Parse).ToList();
        }

        public void Update(Condicion item)
        {
            _icondicionServices.Update(item);
        }
    }
}
