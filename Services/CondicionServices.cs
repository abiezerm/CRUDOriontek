using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICondicionServices : ICommonOperationServices<Condicion>
    {

    }
    public class CondicionServices : IServiceBase<Condicion>, ICondicionServices
    {
        ICondicionRepository _icondicionRepository = new CondicionRepository(DatosConexion.GetDbConnection());
        public void Add(IEnumerable<Condicion> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Condicion entity)
        {
            _icondicionRepository.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Condicion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Condicion> Get()
        {
          return  _icondicionRepository.Get();
        }

        public Condicion Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Condicion Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Condicion> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Condicion> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Condicion> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(Condicion entity)
        {
            _icondicionRepository.Update(entity);
        }
    }
}
