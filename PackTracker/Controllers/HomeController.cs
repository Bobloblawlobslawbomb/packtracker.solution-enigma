using Microsoft.AspNetCore.Mvc;
using PackTracker.Models;

namespace PackTracker.Controllers
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