using Entidad;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IDescripcionServices: ICommonOperationServices<Descripcion>
    {

    }
    public class DescripcionServices : IServiceBase<Descripcion>, IDescripcionServices
    {
        IDescripcionRepository _idescripcionRepository = new DescripcionRepository(DatosConexion.GetDbConnection());
        public void Add(IEnumerable<Descripcion> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Descripcion entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Descripcion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Descripcion> Get()
        {
            throw new NotImplementedException();
        }

        public Descripcion Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public Descripcion Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Descripcion> GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetCircuit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Descripcion> GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Descripcion> GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        public void Update(Descripcion entity)
        {
            throw new NotImplementedException();
        }
    }
}
