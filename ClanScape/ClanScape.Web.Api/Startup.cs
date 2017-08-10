using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using ClanScape.Web.Api;
using ClanScape.Web.Api.Common.Helpers;
using ClanScape.Web.Api.Common.Interfaces.Repositories;
using ClanScape.Web.Api.Common.Interfaces.Services;
using ClanScape.Web.Api.Common.Repositories;
using ClanScape.Web.Api.Common.Services;
using ClanScape.Data.Access.Context;
using ClanScape.Data.Objects.Tables;
using Microsoft.Owin;
using Owin;

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
            builder.RegisterType<Service<Player>>().As<IService<Player>>().InstancePerLifetimeScope();
            builder.RegisterType<Repository<Player>>().As<IRepository<Player>>().InstancePerLifetimeScope();
        }
    }
}