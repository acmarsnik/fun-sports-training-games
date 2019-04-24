using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using FstgWebApi.BusinessContracts;
using FstgWebApi.BusinessLogic;
using FstgWebApi.DataContracts;
using FstgWebApi.DataModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FstgWebApi.DependencyInjection
{
    public class WebApiDependencyConfiguration
    {
        public static IContainer Configure(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<OdbcAgDataWarehouseConnectionStringProvider>().As<IConnectionStringProvider>().AsSelf();
            //builder.RegisterType<PumpStatusConverter>().As<IPumpStatusConverter>().InstancePerLifetimeScope();

            //builder.RegisterType<AgDataWarehouseOdbcContext>().WithParameter(
            //new ResolvedParameter(
            //	(pi, ctx) => pi.ParameterType == typeof(IConnectionFactory),
            //	(pi, ctx) => ctx.ResolveKeyed<IConnectionFactory>("odbc-agdatawarehouse")))
            //.As<IOdbcDbContext>().Keyed<IOdbcDbContext>("odbc-agdatawarehouse");

            //(options =>
            //{
            //    options.ConnectionString
            //        = Configuration.GetSection("MongoConnection:ConnectionString").Value;
            //    options.Database
            //        = Configuration.GetSection("MongoConnection:Database").Value;
            //});
            builder.RegisterType<ScoresManager>().As<IScoresManager>().InstancePerLifetimeScope();
            builder.RegisterType<UserScoresManager>().As<IUserScoresManager>().InstancePerLifetimeScope();

            builder.Populate(services);
            return builder.Build();
        }
    }
}
