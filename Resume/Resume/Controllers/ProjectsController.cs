using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Collections.Generic;

namespace Resume.Controllers
{
  public class ProjectsController : Controller
  {
    public ProjectsController()
    {
    }

    public IActionResult Index()
    {
      var author = new Author()
      {
        Name = "Ionut Enache",
        ProfileImage = "/images/profilePic.jpg",
        Twitter = "https://twitter.com/ionutenache_"
      };

      var articles = new List<Article>()
      {
        new Article()
        {
          Title = "Clang Power Tools",
          Author = author,
          Date = "September 27, 2017",
          ShortDescription = "Clang Power Tools encapsulates in a small package all the Clang LLVM features you need to modernize and improve your code. More than that, Clang Power Tools comes as a Visual Studio Extension, so it’s easy to install and even more comfortable to use directly from the IDE due to the great integration with the development environment.",
          Image = "/images/articleImage.png",
          ControllerName = "Projects",
          ActionName = "ClangPowerTools"
        },
        new Article()
        {
          Title = "RC Strings",
          Author = author,
          Date = "July 4, 2016",
          ShortDescription = "This is a Visual Studio Extension which enables you to add strings to RC (Win32 projects) string table from the Context Menu of Code Editor. Speed up the development process and it's filling all the IDs gaps from your resource file. Also, it minimizes the possibility of conflicts with team members when all are working on the same file.",
          Image = "/images/articleImage.png",
          ControllerName = "Projects",
          ActionName = "RcStrings"
        },
      };

      return View(articles);
    }

    public IActionResult ClangPowerTools()
    {
      return View();
    }

    public IActionResult RcStrings()
    {
      return View();
    }

  }
}
