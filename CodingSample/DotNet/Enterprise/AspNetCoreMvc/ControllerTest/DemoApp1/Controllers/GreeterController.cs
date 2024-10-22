using DemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

public class GreeterController : Controller
{
    //action method for path /Greeter/Clock and GET verb
    public IActionResult Clock()
    {
        return Content(DateTime.Now.ToString());
    }

    public IActionResult Meet(string id, [FromServices] ICounter counting)
    {
        var info = new 
        {
            VisitorName = id,
            GreetCount = counting.CountNext(id)
        };
        string browser = Request.Headers.UserAgent;
        if(browser.Contains("Mobile"))
            return View("~/Views/Hello.cshtml", info);
        return View("~/Views/Welcome.cshtml", info);
    }
}