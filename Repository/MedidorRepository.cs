using Dapper;
using Edeeste.IRepository;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMedidorRepository: IRepositoryOperationBase<Medidor>
    {
        void Add(TipoMedidor item);
        void Update(TipoMedidor item);
        void DeleteTipo(TipoMedidor item);
        IEnumerable<TipoMedidor> GetTipo();
    }
    public class MedidorRepository : RepositoryBase<Medidor>, IMedidorRepository
    {
        public MedidorRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }

        public void Add(TipoMedidor item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public void DeleteTipo(TipoMedidor item)
        {
            var query = base.BuilderOfDelete(item);

            if (DbConnection.State == ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }

        public IEnumerable<TipoMedidor> GetTipo()
        {
            var query = new StringBuilder("select * from Tipo_Medidor r ");

            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<TipoMedidor>(query.ToString(), commandTimeout: CommandTimeout);
        }

        public void Update(TipoMedidor item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
    }
}
