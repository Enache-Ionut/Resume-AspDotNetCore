﻿using EmailService;
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
    private readonly IEmailSender _emailSender;

    public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
    {
      _logger = logger;
      _emailSender = emailSender;
    }

    public IActionResult Index()
    {
      var pageInfoViewModel = new List<PageInformationModel>()
      {
        new PageInformationModel
        {
          ControllerName = "Home",
          ActionName = "CurriculumVitae",
          DisplayName = "CV",
          IconClassName = "fa fa-address-card"
        },
        new PageInformationModel
        {
          ControllerName = "Projects",
          ActionName = "Index",
          DisplayName = "Projects",
          IconClassName = "fa fa-briefcase"
        },
        new PageInformationModel
        {
          ControllerName = "Home",
          ActionName = "About",
          DisplayName = "About",
          IconClassName = "fa fa-info"
        },
        new PageInformationModel
        {
          ControllerName = "Home",
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
      var email = "@gmail.com";
      var message = new Message(new string[] { email },
        contactModel.Subject, $"From: {email}\n\n" + "Message" + contactModel.Message);

      _emailSender.SendEmail(message);

      return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
