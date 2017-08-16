using ClanScape.Data.Objects.Tables;
using System.Linq;

namespace ClanScape.Web.Api.Factory.Interfaces
{
    public interface IPlayerFactory
    {
        IQueryable<Player> All();
        void Add(string name);
    }
}
