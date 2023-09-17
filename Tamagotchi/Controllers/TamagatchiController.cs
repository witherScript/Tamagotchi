using System.Collections.Generic;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Controller
{
  public class TamagotchiController : Controller
  {
    [HttpGet('/')]
    public ActionResult Index()
    { 
      Tamagotchi tom = new Tamagotchi();
      return View(tom);
    }

  } 
}