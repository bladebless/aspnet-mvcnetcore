//Программы, игры и их исходные коды
//www.interestprograms.ru

using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}