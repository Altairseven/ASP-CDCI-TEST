using System.Web;
using System.Web.Mvc;

namespace MVC_App_CDCI_Test {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
