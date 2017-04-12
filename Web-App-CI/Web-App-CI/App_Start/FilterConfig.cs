using System.Web;
using System.Web.Mvc;

namespace Web_App_CI
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters( GlobalFilterCollection filters )
    {
      filters.Add ( new HandleErrorAttribute ( ) );
    }
  }
}
