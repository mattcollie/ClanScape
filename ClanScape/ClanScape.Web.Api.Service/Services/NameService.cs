using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Services;
using ClanScape.Web.Api.Service.Interfaces;
using ClanScape.Web.Api.Repository.Interfaces;
using System;

namespace ClanScape.Web.Api.Service.Services
{
    public class NameService : Service<Name>, INameService
    {
        protected INameRepository NameRepository { get; set; }

        public NameService(INameRepository repository) : base(repository)
        {
            NameRepository = repository;
        }

        public bool DoesNameExist(string name)
        {
            return NameRepository.DoesNameExist(name);
        }

        public bool Add(Name item)
        {
            return NameRepository.Add(item);
        }

        public string GetLatestName(Guid playerId)
        {
            return NameRepository.GetLatestName(playerId);
        }

        public Name GetLatestNameByName(string name)
        {
            return NameRepository.GetLatestNameByName(name);
        }
    }
}
