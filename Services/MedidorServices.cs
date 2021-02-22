using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IMedidorServices : ICommonOperationServices<Medidor>
    {
        void Add(TipoMedidor item);
        void Update(TipoMedidor item);
        void DeleteTipo(TipoMedidor item);
        IEnumerable<TipoMedidor> GetTipo();
    }
    public class MedidorServices : IServiceBase<Medidor>, IMedidorServices
    {
        IMedidorRepository _imedidorRepository = new MedidorRepository(DatosConexion.GetDbConnection());
        public void Add(IEnumerable<Medidor> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(TipoMedidor item)
        {
            _imedidorRepository.Add(item);
        }

        public void Add(Medidor entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Medidor entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteTipo(TipoMedidor item)
        {
            _imedidorRepository.DeleteTipo(item);
        }

        public IEnumerable<Medidor> Get()
        {
            throw new NotImplementedException();
        }

        public Medidor Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Medidor Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medidor> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medidor> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medidor> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoMedidor> GetTipo()
        {
          return  _imedidorRepository.GetTipo();
        }

        public void Update(TipoMedidor item)
        {
            _imedidorRepository.Update(item);
        }

        public void Update(Medidor entity)
        {
            throw new NotImplementedException();
        }
    }
}
