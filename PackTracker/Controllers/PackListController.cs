using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackTracker.Models;

namespace PackTracker.Controllers
{
  public class PackListController : Controller
  {
    [HttpGet("/packlist/new")]
    public ActionResult CreateForm()
    {
      return View();
    }


  }
}