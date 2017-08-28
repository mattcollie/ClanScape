using ClanScape.Data.Objects.Client.RsDto;
using ClanScape.RS.Api.Common.Services;
using ClanScape.RS.Api.Repository.Interfaces;
using ClanScape.RS.Api.Service.Interfaces;
using System.Threading.Tasks;

namespace ClanScape.RS.Api.Service.Services
{
    public class SkillService : Service<PlayerSkillsRsDto>, ISkillService
    {
        protected ISkillRepository SkillRepository { get; set; }

        public SkillService(ISkillRepository repository) : base(repository)
        {
            SkillRepository = repository;
        }

        public async Task<PlayerSkillsRsDto> Get(string name)
        {
            return await SkillRepository.Get(name);
        }
    }
}
