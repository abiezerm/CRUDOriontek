using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Edeeste.IRepository;

namespace Repository
{
 public   class DatosConexion
    {


        public static DbConnectionObj GetDbConnection()
        {
            const string key = "Conexion";
            return GetDbConnection(key);
        }

    
        private static DbConnectionObj GetDbConnection(string key)
        {
            var keyTimeout = key + "Timeout";
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings[key].ConnectionString);
            int timeOut;
            if (!int.TryParse(ConfigurationManager.AppSettings[keyTimeout], out timeOut)) timeOut = 8;
            var dbConnection = new DbConnectionObj
            {
                DbConnection = connection,
                TimeOut = timeOut
            };
            return dbConnection;
        }
        //private static DbConnectionObj GetDbConnectionOracle(string key)
        //{
        //    var keyTimeout = key + "Timeout";
        //    var connection = new OracleConnection(ConfigurationManager.ConnectionStrings[key].ConnectionString);
        //    int timeOut;
        //    if (!int.TryParse(ConfigurationManager.AppSettings[keyTimeout], out timeOut)) timeOut = 8;
        //    var dbConnection = new DbConnectionObj
        //    {
        //        DbConnection = connection,
        //        TimeOut = timeOut
        //    };
        //    return dbConnection;
        //}
        //private SqlConnection _datos;
        //public DatosConexion()
        //{
        //    _datos = new SqlConnection(CadenaConexion);
        //}

        //private string CadenaConexion
        //{
        //    get
        //    {
        //        return ConfigurationManager.ConnectionStrings["Conexion"].ToString();
        //    }
        //}
        //public SqlConnection ObtenerConexion()
        //{
        //    return _datos;
        //}
    }
}
