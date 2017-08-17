using ClanScape.Data.Objects.Client.Dto;
using ClanScape.Data.Objects.Tables;
using System.Linq;

namespace ClanScape.Web.Api.Factory.Interfaces
{
    public interface IPlayerFactory
    {
        IQueryable<Player> All();
        Player Add(string name);
        PlayerData GetPlayer(string name);
    }
}
