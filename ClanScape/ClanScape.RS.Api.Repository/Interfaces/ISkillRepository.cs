using ClanScape.Data.Objects.Client.RsDto;
using ClanScape.RS.Api.Common.Interfaces.Repositories;
using System.Threading.Tasks;

namespace ClanScape.RS.Api.Repository.Interfaces
{
    public interface ISkillRepository : IRepository<PlayerSkillsRsDto>
    {
        Task<PlayerSkillsRsDto> Get(string name);
    }
}
