using ClanScape.Data.Objects.Tables;
using ClanScape.Web.Api.Common.Interfaces.Repositories;

namespace ClanScape.Web.Api.Repository.Interfaces
{
    public interface INameRepository : IRepository<Name>
    {
        bool DoesNameExist(string name);
    }
}
