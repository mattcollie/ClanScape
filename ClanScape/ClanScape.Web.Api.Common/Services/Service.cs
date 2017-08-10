using System.Linq;
using ClanScape.Web.Api.Common.Interfaces.Services;
using ClanScape.Web.Api.Common.Interfaces.Repositories;

namespace ClanScape.Web.Api.Common.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public Service(IRepository<T> repository)
        {
            Repository = repository;
        }

        protected IRepository<T> Repository { get; set; }

        public bool Delete(object id)
        {
            return Repository.Delete(id);
        }
        
        public IQueryable<T> All()
        {
            return Repository.All();
        }

        public T GetById(object id)
        {
            return Repository.GetById(id);
        }
    }
}
