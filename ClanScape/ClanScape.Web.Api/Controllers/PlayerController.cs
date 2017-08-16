using System;
using System.Linq;
using System.Web.Http;
using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Factory.Interfaces;

namespace ClanScape.Web.Api.Controllers
{
    [RoutePrefix("api/player")]
    public class PlayerController : ApiController
    {
        protected IPlayerFactory PlayerFactory { get; set; }

        public PlayerController(IPlayerFactory factory)
        {
            PlayerFactory = factory;
        }

        [HttpGet]
        public IQueryable<Player> Index()
        {
            return PlayerFactory.All();
        }

        [HttpGet]
        [Route("add/{name}")]
        public void Add(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            PlayerFactory.Add(name);
        }
    }
}
