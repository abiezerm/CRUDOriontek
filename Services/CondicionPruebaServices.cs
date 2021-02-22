using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICondicionPruebaServices : ICommonOperationServices<CondicionPrueba>
    {

    }
 public   class CondicionPruebaServices : IServiceBase<CondicionPrueba>, ICondicionPruebaServices
    {

        ICondicionPruebaRepository _icondicionPruebaRepository = new CondicionPruebaRepository(DatosConexion.GetDbConnection());
        public void Add(IEnumerable<CondicionPrueba> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(CondicionPrueba entity)
        {
            _icondicionPruebaRepository.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(CondicionPrueba entity)
        {
            _icondicionPruebaRepository.Add(entity);
        }

        public IEnumerable<CondicionPrueba> Get()
        {
            return _icondicionPruebaRepository.Get();
        }

        public CondicionPrueba Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public CondicionPrueba Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CondicionPrueba> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CondicionPrueba> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CondicionPrueba> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(CondicionPrueba entity)
        {
            _icondicionPruebaRepository.Update(entity);
        }
    }
}
