using System.Dynamic;

namespace Nancy.UI.Web.Modules
{
    public class BaseModule : NancyModule
    {
        public dynamic Model = new ExpandoObject();
    }
}
