using System;
using System.Linq;
using ClanScape.Web.Api.Factory.Interfaces;
using ClanScape.Web.Api.Service.Interfaces;
using ClanScape.Data.Objects.Tables;
using ClanScape.Data.Objects.Client.Dto;

namespace ClanScape.Web.Api.Factory.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        protected IPlayerService PlayerSerivce { get; set; }
        protected INameService NameService { get; set; }

        public PlayerFactory(IPlayerService playerSerivce, INameService nameService)
        {
            PlayerSerivce = playerSerivce;
            NameService = nameService;
        }

        public IQueryable<Player> All()
        {
            return PlayerSerivce.All();
        }

        public Player Add(string name)
        {
            if (NameService.DoesNameExist(name))
                return PlayerSerivce.GetById(NameService.GetLatestNameByName(name).PlayerId);

            Player playerItem = new Player
            {
                Id = Guid.NewGuid(),
                QuestPoints = -1
            };

            // player added successfully
            if (!PlayerSerivce.Add(playerItem))
                throw new Exception("Failed to add player");

            Name nameItem = new Name
            {
                PlayerId = playerItem.Id,
                PlayerName = name
            };

            if (!NameService.Add(nameItem))
                throw new Exception("Failed to add name");

            return playerItem;
        }

        public PlayerData GetPlayer(string name)
        {
            Player playerData = Add(name);

            PlayerData player = new PlayerData
            {
                Id = playerData.Id,
                QuestPoints = playerData.QuestPoints,
                Name = NameService.GetLatestName(playerData.Id)
            };


            return player;
        }
    }
}
