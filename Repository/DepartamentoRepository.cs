using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDepartamentoRepository : IRepositoryOperationBase<Departamento>
    {

    }
    public class DepartamentoRepository : RepositoryBase<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
