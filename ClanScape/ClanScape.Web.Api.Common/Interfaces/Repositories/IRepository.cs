using System.Linq;

namespace ClanScape.Web.Api.Common.Interfaces.Repositories
{
    public interface IRepository<out T>
    {
        IQueryable<T> All();
        T GetById(object id);
        bool Delete(object id);
    }
}