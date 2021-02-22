using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOficinaRepository: IRepositoryOperationBase<Oficina>
    {

    }
    public class OficinaRepository : RepositoryBase<Oficina>, IOficinaRepository
    {
        public OficinaRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
