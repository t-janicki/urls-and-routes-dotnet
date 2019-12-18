using Microsoft.AspNetCore.Mvc;

namespace UrlsAndRoutes.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() => View("Result", new Result{
            Controller = nameof(HomeController),
            Action = nameof(Index)
        });

        public ViewResult CustomVariable(string id)
        {
            Result r = new Result {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable), };
            r.Data["id"] = id ?? "<brak wartości>";
            return View("Result", r); }
    }
}