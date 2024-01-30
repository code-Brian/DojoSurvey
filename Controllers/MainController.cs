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

    [HttpGet("results/{text}/{number}")]
    public ViewResult Results(string text, int number)
    {
        ViewBag.Text = text;
        ViewBag.Number = number;
        Console.WriteLine(text);
        Console.WriteLine(number);
        return View();
    }

    [HttpPost("dojoForm")]
    public RedirectToActionResult DojoForm(string Text, int Number)
    { 
        Console.WriteLine($"Text before redirect: {Text}");
        Console.WriteLine($"Number before redirect: {Number}");
        return RedirectToAction("Results", new {text = Text, number = Number});
    }
}