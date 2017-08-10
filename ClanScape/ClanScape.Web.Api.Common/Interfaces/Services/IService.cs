using System.Linq;

namespace ClanScape.Web.Api.Common.Interfaces.Services
{
    public interface IService<out T>
    {
        IQueryable<T> All();
        T GetById(object id);
        bool Delete(object id);
    }
}