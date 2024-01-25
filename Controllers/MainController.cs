using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class MainController : Controller
{
    [HttpGet("/")]
    public ViewResult Main()
    {
        return View();
    }

    [HttpGet("DojoSurvey")]
    public ViewResult DojoSurvey()
    {
        return View();
    }
}