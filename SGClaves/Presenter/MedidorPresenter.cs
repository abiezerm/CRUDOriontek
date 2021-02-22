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
    public interface IMedidorPresenter : IPresenter<IMedidor>
    {
        void Add(Medidor item);
        void Update(Medidor item);
        void Delete(TipoMedidor item);
        IEnumerable<MedidorModel> Get();
        void Add(TipoMedidor item);
        void Update(TipoMedidor item);
        void DeleteTipo(TipoMedidor item);
        IEnumerable<TipoMedidorModel> GetTipo();
    }
    public class MedidorPresenter : PresenterBase, IMedidorPresenter
    {
        IMedidorServices _imedidorservices = new MedidorServices();
        public IMedidor View
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

        public void Add(TipoMedidor item)
        {
            _imedidorservices.Add(item);
        }

        public void Add(Medidor item)
        {
            throw new NotImplementedException();
        }

        public void Delete(TipoMedidor item)
        {
            throw new NotImplementedException();
        }

        public void DeleteTipo(TipoMedidor item)
        {
            _imedidorservices.DeleteTipo(item);
        }

        public IEnumerable<MedidorModel> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoMedidorModel> GetTipo()
        {
            var tipomedidor = _imedidorservices.GetTipo();
            return tipomedidor.Select(TipoMedidorModel.Parse).ToList();
        }

        public void Update(TipoMedidor item)
        {
            _imedidorservices.Update(item);
        }

        public void Update(Medidor item)
        {
            throw new NotImplementedException();
        }
    }
}
