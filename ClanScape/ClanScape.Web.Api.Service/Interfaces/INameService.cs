using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Interfaces.Services;

namespace ClanScape.Web.Api.Service.Interfaces
{
    public interface INameService : IService<Name>
    {
        Name GetLatestPlayerByName(string name);
        bool Add(Name item);
        bool DoesNameExist(string name);
        string GetLatestName(System.Guid playerId);
    }
}
