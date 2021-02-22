using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Entidad;
using Edeeste.IRepository;
using System.Data;

namespace Repository
{
    public interface IComunicacionRepository :IRepositoryOperationBase<Comunicacion>
    {
        void Delete(int id);
      
    }
    public class ComunicacionRepository : RepositoryBase<Comunicacion> , IComunicacionRepository
    {
       
        public ComunicacionRepository(DbConnectionObj dbConnection) : base(dbConnection)
        {
        }
        public new void Add(Comunicacion item)
        {
            var query = base.BuilderOfInsert(item);

            if (DbConnection.State == ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);

        }
        public override void Update(Comunicacion item)
        {
            var query = base.BuilderOfUpdate(item);

            if (DbConnection.State == ConnectionState.Closed) DbConnection.Open();
            DbConnection.Execute(query, commandTimeout: CommandTimeout);
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public override IEnumerable<Comunicacion> Get()
        {
            var query = new StringBuilder("select * from Comunicacion r ");
          
            if (DbConnection.State == System.Data.ConnectionState.Closed) DbConnection.Open();
            return DbConnection.Query<Comunicacion>(query.ToString(), commandTimeout: CommandTimeout);

        }
    }
}
