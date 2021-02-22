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
    public interface IModeloPresenter : IPresenter<IModelo>
    {
        void Add(Modelo item);
        void Update(Modelo item);
        void Delete(Modelo item);
        IEnumerable<ModeloModel> Get();
    }
    public class ModeloPresenter : PresenterBase, IModeloPresenter
    {
        IModeloServices _imodeloServices = new ModeloServices();
        public IModelo View
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

        public void Add(Modelo item)
        {
            _imodeloServices.Add(item);
        }

        public void Delete(Modelo item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModeloModel> Get()
        {
            var modelo = _imodeloServices.Get();
            return modelo.Select(ModeloModel.Parse).ToList();
        }

        public void Update(Modelo item)
        {
            _imodeloServices.Update(item);
        }
    }
}
