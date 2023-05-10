using PlacesYouveBeen.Models;
using Microsoft.AspNetCore.Mvc;

namespace PlacesYouveBeen.Controllers
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
