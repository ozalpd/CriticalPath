using System.Web;
using System.Web.Mvc;

namespace OzzUtils.Web.Mvc
{
   public static class HtmlHelperExtensions
    {
        public static IHtmlString JsonFor<T>(this HtmlHelper helper, T obj)
        {
            return helper.Raw(obj.ToJson());
        }
    }
}
