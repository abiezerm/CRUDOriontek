using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IModuloRepository: IRepositoryOperationBase<Modelo>
    {

    }
    public class ModuloRepository : RepositoryBase<Modelo>, IModuloRepository
    {
        public ModuloRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
