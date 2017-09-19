using ClanScape.Data.Objects.Client.Dto;
using ClanScape.Data.Objects.Client.RsDto;
using ClanScape.Data.Objects.Tables;
using System.Linq;
using System.Threading.Tasks;

namespace ClanScape.Web.Api.Factory.Interfaces
{
    public interface IPlayerFactory
    {
        IQueryable<Player> All();
        Task<Player> Add(string name);
        Task<PlayerData> GetPlayer(string name);
        Task<PlayerSkillsRsDto> GetStats(string name);
    }
}
