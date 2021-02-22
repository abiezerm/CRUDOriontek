using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDescripcionRepository: IRepositoryOperationBase<Descripcion>
    {

    }
    public class DescripcionRepository : RepositoryBase<Descripcion>, IDescripcionRepository
    {
        public DescripcionRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
