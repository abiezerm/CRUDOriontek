using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Services
{
    public interface IComunicacionService : ICommonOperationServices<Comunicacion>
    {

    }
    public class ComunicacionService : IServiceBase<Comunicacion>, IComunicacionService
    {

        IComunicacionRepository _icomunicacionRepository = new ComunicacionRepository(DatosConexion.GetDbConnection());
     

        public void Add(IEnumerable<Comunicacion> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Comunicacion entity)
        {
            _icomunicacionRepository.Add(entity);
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Comunicacion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comunicacion> Get()
        {
            return _icomunicacionRepository.Get();
        }

        public Comunicacion Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Comunicacion Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comunicacion> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comunicacion> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comunicacion> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(Comunicacion entity)
        {
            _icomunicacionRepository.Update(entity);
        }
    }
}
