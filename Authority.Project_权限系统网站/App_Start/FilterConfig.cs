using System.Web;
using System.Web.Mvc;

namespace Authority.Project_权限系统网站
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
