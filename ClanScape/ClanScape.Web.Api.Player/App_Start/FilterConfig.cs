using System.Web;
using System.Web.Mvc;

namespace ClanScape.Web.Api.Player
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
