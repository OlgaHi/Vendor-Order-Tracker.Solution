using Microsoft.AspNetCore.Mvc;

namespace Tracker.Controllers
{
  public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }

}