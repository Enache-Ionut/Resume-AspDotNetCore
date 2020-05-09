using Microsoft.AspNetCore.Mvc;

namespace Resume.Controllers
{
  public class ProjectsController : Controller
  {
    public ProjectsController()
    {
    }

    public IActionResult Index()
    {
      return View();
    }

  }
}
