using ClanScape.RS.Api.Common.Interfaces.Repositories;
using ClanScape.RS.Api.Common.Interfaces.Services;

namespace ClanScape.RS.Api.Common.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public Service(IRepository<T> repository)
        {
            Repository = repository;
        }

        protected IRepository<T> Repository { get; set; }
    }
}
