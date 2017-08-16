using System;
using ClanScape.Data.Access.Context;
using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Repositories;
using ClanScape.Web.Api.Repository.Interfaces;

namespace ClanScape.Web.Api.Repository.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(ClanScapeContext context) : base(context)
        {
        }
    }
}
