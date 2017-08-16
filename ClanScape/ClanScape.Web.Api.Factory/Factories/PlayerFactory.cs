﻿using System;
using System.Linq;
using ClanScape.Web.Api.Factory.Interfaces;
using ClanScape.Web.Api.Service.Interfaces;
using ClanScape.Data.Objects.Tables;

namespace ClanScape.Web.Api.Factory.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        protected IPlayerService PlayerSerivce { get; set; }

        public PlayerFactory(IPlayerService playerSerivce)
        {
            PlayerSerivce = playerSerivce;
        }

        public IQueryable<Player> All()
        {
            return PlayerSerivce.All();
        }

        public void Add(string name)
        {
            Player player = new Player
            {
                Id = Guid.NewGuid(),
                QuestPoints = -1
            };

            // player added successfully
            if(PlayerSerivce.Add(player))
            {

            }
        }
    }
}
