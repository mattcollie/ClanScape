using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Services;
using ClanScape.Web.Api.Service.Interfaces;
using ClanScape.Web.Api.Repository.Interfaces;

namespace ClanScape.Web.Api.Service.Services
{
    public class PlayerService : Service<Player>, IPlayerService
    {
        protected IPlayerRepository PlayerRepository { get; set; }

        public PlayerService(IPlayerRepository repository) : base(repository)
        {
            PlayerRepository = repository;
        }

        public bool Add(Player item)
        {
            return PlayerRepository.Add(item);
        }
    }
}
