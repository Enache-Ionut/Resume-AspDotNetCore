using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace Resume.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      var pageInfoViewModel = new List<PageInformationModel>()
      {
        new PageInformationModel
        {
          ActionName = "CurriculumVitae",
          DisplayName = "CV",
          IconClassName = "fa fa-address-card"
        },
        new PageInformationModel
        {
          ActionName = "Projects",
          DisplayName = "Projects",
          IconClassName = "fa fa-briefcase"
        },
        new PageInformationModel
        {
          ActionName = "About",
          DisplayName = "About",
          IconClassName = "fa fa-info"
        },
        new PageInformationModel
        {
          ActionName = "Contact",
          DisplayName = "Contact",
          IconClassName = "fa fa-phone"
        }
      };

      return View(pageInfoViewModel);
    }

    public IActionResult CurriculumVitae()
    {
      return View();
    }

    public IActionResult Projects()
    {
      return View();
    }

    public IActionResult About()
    {
      return View();
    }

    public IActionResult Contact()
    {
      var contactModel = new Contact();
      return View(contactModel);
    }

    [HttpPost]
    [Route("/Home/SendMessage")]
    public IActionResult SendMessage(Contact contactModel)
    {
      if (!ModelState.IsValid)
      {
        return View("Contact", contactModel);
      }

      //TODO Send a email with the data from contactModel to my personal email


      return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
