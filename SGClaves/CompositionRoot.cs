using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Edeeste.IRepository;
using Repository;
using Services;

namespace SGClaves
{
    class CompositionRoot
    {
        DatosConexion _conex;
        public CompositionRoot()
        {
            _conex = new DatosConexion();
        }

        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            //Repositories

            LoadBuilderComponents(ref builder, typeof(ComunicacionRepository).Assembly, DatosConexion.GetDbConnection() );



            //STL
            LoadBuilderComponents(ref builder, typeof(IComunicacionRepository).Assembly); //Interfaces
            LoadBuilderComponents(ref builder, typeof(ComunicacionRepository).Assembly, DatosConexion.GetDbConnection());

            ////STL -Security
            //LoadBuilderComponents(ref builder, typeof(Edeeste.Security.Intraestructure.Repositories.IUserRepository).Assembly);
            //LoadBuilderComponents(ref builder,
            //                      typeof(Edeeste.Security.Intraestructure.Repositories.UserRepository).Assembly,
            //                      StringConnectionHelper.GetDbConnectionTelemedicion());


            //////Services
            //LoadBuilderComponents(ref builder, typeof(Edeeste.Security.Framework.IUserService).Assembly);
            //LoadBuilderComponents(ref builder, typeof(Edeeste.Security.Framework.Services.UserService).Assembly);

            //LoadBuilderComponents(ref builder, typeof(IComunicacionService).Assembly);
            //LoadBuilderComponents(ref builder, typeof(ComunicacionService).Assembly);


            ////Interceptors
            //builder.RegisterType<Security>().AsSelf();
            //builder.RegisterType<ExceptionHandler>().AsSelf();
            ////builder.RegisterType<TaskCancel>().AsSelf();

            //Presenter
            //LoadBuilderComponents(ref builder, typeof(Presenter.IComunicacionPresenter).Assembly);
            //LoadBuilderComponents(ref builder, typeof(Presenter.ComunicacionesPrensenter).Assembly);

            var result = builder.Build();
            return result;
        }
        private static void LoadBuilderComponents(ref ContainerBuilder builder, Assembly assembly, DbConnectionObj dbConnectionObj)
        {
            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .WithParameter("dbConnection", dbConnectionObj)
                   .AsImplementedInterfaces();
        }
        private static void LoadBuilderComponents(ref ContainerBuilder builder, Assembly assembly)
        {
            builder.RegisterAssemblyTypes(assembly)
                  .Where(t => t.Name.EndsWith("Repository"))
                  .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(assembly)
            //       .Where(t => t.Name.EndsWith("Service"))
            //       .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(assembly)
            //       .Where(t => t.Name.EndsWith("Presenter"))
            //       .AsImplementedInterfaces();
            ////.InterceptorByDefault();
        }
    }
}
