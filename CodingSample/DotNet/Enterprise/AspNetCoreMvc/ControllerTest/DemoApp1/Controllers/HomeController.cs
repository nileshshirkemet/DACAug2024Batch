using Microsoft.AspNetCore.Mvc;
using Tourism.Models;

namespace DemoApp.Controllers;

public class HomeController(SiteModel model) : Controller
{
    public IActionResult Index()
    {
        var visitors = model.GetVisitors();
        return View(visitors); //renders ~/Views/{current-controller-name}/{current-method-name}.cshtml
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string visitorId, int visitorRating)
    {
        model.AcceptVisit(visitorId, visitorRating);
        return RedirectToAction("Index");
    }
}