using System.Linq;
using System.Web.Http;
using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Interfaces.Services;

namespace ClanScape.Web.Api.Controllers
{
    [RoutePrefix("api/player")]
    public class PlayerController : BaseController<Player>
    {
        public PlayerController(IService<Player> service) : base(service)
        {
        }

        [HttpGet]
        public override IQueryable<Player> Index()
        {
            return base.Index();
        }
    }
}
