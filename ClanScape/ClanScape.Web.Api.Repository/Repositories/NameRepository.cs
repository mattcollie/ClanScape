using System;
using System.Linq;
using ClanScape.Data.Access.Context;
using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Repositories;
using ClanScape.Web.Api.Repository.Interfaces;

namespace ClanScape.Web.Api.Repository.Repositories
{
    public class NameRepository : Repository<Name>, INameRepository
    {
        public NameRepository(ClanScapeContext context) : base(context)
        {
        }

        public bool DoesNameExist(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            IQueryable<Name> query = from n in Context.Names
                                     group n by n.PlayerId into g
                                     select g.OrderByDescending(t => t.Id).FirstOrDefault();
            return query.Any(n => n.PlayerName == name);
        }
    }
}
