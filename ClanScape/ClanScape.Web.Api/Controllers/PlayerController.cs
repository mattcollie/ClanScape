﻿using System;
using System.Linq;
using System.Web.Http;
using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Factory.Interfaces;
using ClanScape.Data.Objects.Client.Dto;
using System.Threading.Tasks;
using ClanScape.Data.Objects.Client.RsDto;

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
        [Route("GetStats/{name}")]
        public async Task<PlayerSkillsRsDto> GetStats(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            return await PlayerFactory.GetStats(name);
        }

        [HttpGet]
        [Route("GetUser/{name}")]
        public async Task<PlayerData> GetUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            return await PlayerFactory.GetPlayer(name);
        }
    }
}
