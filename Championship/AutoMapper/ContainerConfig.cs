using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Championship.Application.Interfaces;
using Championship.Application;
using Championship.Domain.Services;
using Championship.Domain.Interfaces.Services;
using Championship.Domain.Interfaces;
using Championship.Infra.Data.Repositories;
using Championship.Domain.Entities;
using Championship.Controllers;
using System.Web.Http;

namespace Championship.AutoMapper
{
    public class ContainerConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder
                .RegisterGeneric(typeof(AppServiceBase<>))
                .As(typeof(IAppServiceBase<>))
                .InstancePerDependency();
            
            builder.RegisterType<TournamentAppService>().As<ITournamentAppService>();

            builder
              .RegisterGeneric(typeof(ServiceBase<>))
              .As(typeof(IServiceBase<>))
              .InstancePerDependency();
            
            builder.RegisterType<TournamentService>().As<ITournamenteService>();

            builder
            .RegisterGeneric(typeof(RepositoryBase<>))
            .As(typeof(IRepositoryBase<>))
            .InstancePerDependency();

            builder.RegisterType<TournamentRepository>().As<ITournamentRepository>();


            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

            //builder.RegisterType<TournamentController>().InstancePerRequest();
            /*     builder.RegisterType<TournamentService>().As<ITournamenteService>();
                 builder.RegisterType<TournamentRepository>().As<ITournamentRepository>();


                // builder.RegisterType<AppServiceBase>().As<IAppServiceBase>();

                // return builder.Build();

                 //builder.RegisterInstance(new AppServiceBase(TEntity)).As<IAppServiceBase>();

                 /* builder.Re(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
                 builder.Bind<ITournamentAppService>().To<TournamentAppService>();

                 kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
                 kernel.Bind<ITournamenteService>().To<TournamentService>();

                 kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
                 kernel.Bind<ITournamentRepository>().To<TournamentRepository>();*/
        }
    }
}