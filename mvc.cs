using Microsoft.AspNetCore.Mvc;
//super basic level of our controller

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
        
    }
}
