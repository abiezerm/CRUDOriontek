using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IMarcaServices : ICommonOperationServices<Marca>
    {

    }
    public class MarcaServices : IServiceBase<Marca>, IMarcaServices
    {
        IMarcaRepository _imarcaRepository = new MarcaRepository(DatosConexion.GetDbConnection());

        public void Add(IEnumerable<Marca> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Marca entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Marca entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> Get()
        {
            throw new NotImplementedException();
        }

        public Marca Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Marca Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(Marca entity)
        {
            throw new NotImplementedException();
        }
    }
}
