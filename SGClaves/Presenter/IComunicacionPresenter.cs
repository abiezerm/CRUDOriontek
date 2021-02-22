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
  public  interface IComunicacionPresenter : IPresenter<IComunicaciones>
    {
        void Add(Comunicacion item);
        void Update(Comunicacion item);
        void Delete(int id);
        IEnumerable<ComunicacionModel> Get();
    }
    public class ComunicacionesPrensenter : PresenterBase, IComunicacionPresenter
    {
        private readonly IComunicacionService _icomunicacionServicio = new ComunicacionService();

        

        public IComunicaciones View
        { get; set;}

        public event CompletedOperationDelegate CompleteEvent;

        public void Add(Comunicacion item)
        {
            _icomunicacionServicio.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ComunicacionModel> Get()
        {
            var item =_icomunicacionServicio.Get();
            return item.Select(ComunicacionModel.Parse).ToList();
        }

        public void Update(Comunicacion item)
        {
            _icomunicacionServicio.Update(item);
        }
    }
}
