using Microsoft.AspNetCore.Mvc;

namespace UrlsAndRoutes.Controllers {
    public class AdminController : Controller {

        public ViewResult Index() => View("Result", new Result{
            Controller = nameof(AdminController),
            Action = nameof(Index)
        });
    }
}