using System.Linq;
using System.Web.Http;
using ClanScape.Web.Api.Common.Interfaces.Services;


namespace ClanScape.Web.Api.Controllers
{
    public abstract class BaseController<T> : ApiController where T : class
    {
        protected virtual IService<T> Service { get; set; }

        protected BaseController(IService<T> service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual IQueryable<T> Index()
        {
            return Service.All();
        }
    }
}
