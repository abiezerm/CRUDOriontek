using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Repository;

namespace Services
{
    public interface IDepartamentoServices : ICommonOperationServices<Departamento>
    {

    }
    public class DepartamentoServices : IServiceBase<Departamento>, IDescripcionServices
    {
        IDepartamentoRepository _idepartamentoRepository = new DepartamentoRepository(DatosConexion.GetDbConnection());
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

        IEnumerable<Departamento> IServiceBase<Departamento>.Get()
        {
            throw new NotImplementedException();
        }

        Departamento IServiceBase<Departamento>.Get(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        Departamento IServiceBase<Departamento>.Get(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Departamento> IServiceBase<Departamento>.GetByStoredProcedure(object parameters)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Departamento> IServiceBase<Departamento>.GetList(KeyValuePair<string, string> value)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Departamento> IServiceBase<Departamento>.GetList(KeyValuePair<string, int> value)
        {
            throw new NotImplementedException();
        }
    }
}
