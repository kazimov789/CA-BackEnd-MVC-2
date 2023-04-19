using Microsoft.AspNetCore.Mvc;

namespace SeconTask_For_BackEnd.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
