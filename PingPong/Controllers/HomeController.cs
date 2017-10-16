using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PingPongGenerator;

namespace PingPongGenerator.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
        return View();
    }
    [Route("/results")]
    public ActionResult Results()
    {
        return View();
    }
  }
}
