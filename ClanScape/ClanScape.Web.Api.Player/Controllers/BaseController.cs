using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClanScape.Web.Api.Player.Controllers
{
    public abstract class BaseController<T> : ApiController where T : class
    {
        protected virtual IService<T> Service { get; set; }
    }
}