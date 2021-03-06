﻿using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using ClanScape.Web.Api;
using ClanScape.Web.Api.Common.Helpers;
using ClanScape.Web.Api.Common.Interfaces.Repositories;
using ClanScape.Web.Api.Common.Interfaces.Services;
using ClanScape.Web.Api.Common.Repositories;
using ClanScape.Web.Api.Repository.Interfaces;
using ClanScape.Web.Api.Repository.Repositories;
using ClanScape.Web.Api.Service.Interfaces;
using ClanScape.Web.Api.Service.Services;
using ClanScape.Web.Api.Common.Services;
using ClanScape.Web.Api.Factory.Interfaces;
using ClanScape.Web.Api.Factory.Factories;
using ClanScape.Data.Access.Context;
using ClanScape.Data.Objects.Tables;
using Microsoft.Owin;
using Owin;
using ClanScape.RS.Api.Repository.Repositories;
using ClanScape.RS.Api.Repository.Interfaces;
using ClanScape.RS.Api.Service.Services;
using ClanScape.RS.Api.Service.Interfaces;
using System.Net.Http;

[assembly: OwinStartup(typeof(Startup))]

namespace ClanScape.Web.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<FixContentTypeHeader>();

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            RegisterServices(builder);

            IContainer container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // Map the help path and force next to be invoked
            app.Map("/Help", appbuilder => appbuilder.UseHandlerAsync((request, response, next) => next()));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
            app.UseAutofacWebApi(GlobalConfiguration.Configuration);
            app.UseWebApi(GlobalConfiguration.Configuration);
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register(c => HttpContext.Current).InstancePerRequest();
            builder.RegisterType<ClanScapeContext>().InstancePerRequest();
            builder.RegisterType<HttpClient>().InstancePerRequest();
            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PlayerService>().As<IPlayerService>().InstancePerLifetimeScope();
            builder.RegisterType<NameRepository>().As<INameRepository>().InstancePerLifetimeScope();
            builder.RegisterType<NameService>().As<INameService>().InstancePerLifetimeScope();
            builder.RegisterType<PlayerFactory>().As<IPlayerFactory>().InstancePerLifetimeScope();
            builder.RegisterType<SkillRepository>().As<ISkillRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SkillService>().As<ISkillService>().InstancePerLifetimeScope();
        }
    }
}