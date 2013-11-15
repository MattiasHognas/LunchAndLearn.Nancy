namespace Nancy.UI.Web.Modules
{
    public class IndexModule : BaseModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                Model.Title = "Lunch & Learn";
                return View["index", Model];
            };
        }
    }
}