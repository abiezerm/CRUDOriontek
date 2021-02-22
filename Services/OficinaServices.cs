using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOficinaServices : ICommonOperationServices<Oficina>
    {

    }
    public class OficinaServices : IServiceBase<Oficina>, IOficinaServices

    {

        IOficinaRepository _ioficinaRepository = new OficinaRepository(DatosConexion.GetDbConnection());
        public void Add(IEnumerable<Oficina> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Oficina entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Oficina entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Oficina> Get()
        {
            throw new NotImplementedException();
        }

        public Oficina Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Oficina Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Oficina> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Oficina> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Oficina> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(Oficina entity)
        {
            throw new NotImplementedException();
        }
    }
}
