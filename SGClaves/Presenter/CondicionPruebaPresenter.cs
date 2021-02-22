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
    public interface ICondicionPruebaPresenter: IPresenter<ICondicionPrueba>
    {
        void Add(CondicionPrueba item);
        void Update(CondicionPrueba item);
        void Delete(CondicionPrueba item);
        IEnumerable<CondicionPruebaModel> Get();
    }
    public class CondicionPruebaPresenter : PresenterBase, ICondicionPruebaPresenter
    {
        ICondicionPruebaServices _icondicionPruebaServices = new CondicionPruebaServices();

        public ICondicionPrueba View
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

        public void Add(CondicionPrueba item)
        {
            _icondicionPruebaServices.Add(item);
        }

        public void Delete(CondicionPrueba item)
        {
            _icondicionPruebaServices.Delete(item);
        }

        public IEnumerable<CondicionPruebaModel> Get()
        {
            var condicionprueba = _icondicionPruebaServices.Get();
            return condicionprueba.Select(CondicionPruebaModel.Parse).ToList();
        }

        public void Update(CondicionPrueba item)
        {
            _icondicionPruebaServices.Update(item);
        }
    }
}
