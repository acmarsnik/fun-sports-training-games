using Autofac;
using Autofac.Extensions.DependencyInjection;
using BusinessContracts;
using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
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
			//	new ResolvedParameter(
			//		(pi, ctx) => pi.ParameterType == typeof(IConnectionFactory),
			//		(pi, ctx) => ctx.ResolveKeyed<IConnectionFactory>("odbc-agdatawarehouse")))
			//	.As<IOdbcDbContext>().Keyed<IOdbcDbContext>("odbc-agdatawarehouse");


			builder.RegisterType<ScoresManager>().As<IScoresManager>().InstancePerLifetimeScope();

			builder.Populate(services);
			return builder.Build();
		}
	}
}
