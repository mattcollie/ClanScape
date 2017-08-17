using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Interfaces.Repositories;

namespace ClanScape.Web.Api.Repository.Interfaces
{
    public interface INameRepository : IRepository<Name>
    {
        Name GetLatestNameByName(string name);
        string GetLatestName(System.Guid playerId);
        bool DoesNameExist(string name);
        bool Add(Name item);
    }
}
