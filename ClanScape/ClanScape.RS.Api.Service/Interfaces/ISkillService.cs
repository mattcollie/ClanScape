using ClanScape.Data.Objects.Client.RsDto;
using ClanScape.RS.Api.Common.Interfaces.Services;
using System.Threading.Tasks;

namespace ClanScape.RS.Api.Service.Interfaces
{
    public interface ISkillService : IService<PlayerSkillsRsDto>
    {
        Task<PlayerSkillsRsDto> Get(string name);
    }
}
