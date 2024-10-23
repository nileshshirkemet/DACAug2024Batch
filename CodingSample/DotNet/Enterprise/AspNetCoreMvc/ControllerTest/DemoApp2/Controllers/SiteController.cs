using Microsoft.AspNetCore.Mvc;
using Tourism.Data;
using Tourism.Models;

namespace DemoApp.Controllers;

[ApiController]
public class SiteController : ControllerBase
{
    [HttpGet("/api/site")]
    public IActionResult ReadVisitors(SiteModel model)
    {
        var visitors = model.GetVisitors();
        if(visitors.Any())
            return Ok(visitors);
        return NotFound();
    }

    [HttpPost("/api/site")]
    public IActionResult WriteVisitor(Traveler input, SiteModel model)
    {
        model.AcceptVisit(input.Id, input.Rating);
        return Ok();
    }
}