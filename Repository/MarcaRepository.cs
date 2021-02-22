using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMarcaRepository: IRepositoryOperationBase<Marca>
    {

    }
    public class MarcaRepository : RepositoryBase<Marca>, IMarcaRepository
    {
        public MarcaRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
    }
}
