using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICondicionRepository: IRepositoryOperationBase<Condicion>
    {

    }
    public class CondicionRepository : RepositoryBase<Condicion>, ICondicionRepository
    {
        public CondicionRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
