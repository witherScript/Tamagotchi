using Microsoft.AspNetCore.Mvc;

namespace Tamagatchi.Controllers
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