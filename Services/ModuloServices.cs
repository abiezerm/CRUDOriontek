using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IModeloServices : ICommonOperationServices<Modelo>
    {

    }
    public class ModeloServices : IServiceBase<Modelo>, IModeloServices
    {
        IModuloRepository _imoduloRepository = new ModuloRepository(DatosConexion.GetDbConnection());
        public void Add(IEnumerable<Modelo> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Modelo entity)
        {
            _imoduloRepository.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Modelo entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modelo> Get()
        {
            return _imoduloRepository.Get();
        }

        public Modelo Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Modelo Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modelo> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modelo> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modelo> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(Modelo entity)
        {
            _imoduloRepository.Update(entity);
        }
    }
}
