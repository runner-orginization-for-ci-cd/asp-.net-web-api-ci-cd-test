using System.Web;
using System.Web.Mvc;

namespace asnetwebapi5_git_actions_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
