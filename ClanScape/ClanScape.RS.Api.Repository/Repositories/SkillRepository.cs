using ClanScape.Data.Objects.Client.RsDto;
using ClanScape.RS.Api.Common.Repositories;
using ClanScape.RS.Api.Repository.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClanScape.RS.Api.Repository.Repositories
{
    public class SkillRepository : Repository<PlayerSkillsRsDto>, ISkillRepository
    {
        public SkillRepository(HttpClient client) : base(client)
        {
        }

        public async Task<PlayerSkillsRsDto> Get(string name)
        {
            PlayerSkillsRsDto player = new PlayerSkillsRsDto
            {
                Name = name
            };

            HttpResponseMessage response = await Client.GetAsync($"/m=hiscore/index_lite.ws?player={name}");
            if (response.IsSuccessStatusCode)
            {
                string stats = await response.Content.ReadAsAsync<string>();
            }

            return player;
        }
    }
}
