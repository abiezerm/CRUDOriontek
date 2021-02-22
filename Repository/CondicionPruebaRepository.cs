using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public interface ICondicionPruebaRepository: IRepositoryOperationBase<CondicionPrueba>
    {

    }
    public class CondicionPruebaRepository : RepositoryBase<CondicionPrueba>, ICondicionPruebaRepository
    {
        public CondicionPruebaRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
