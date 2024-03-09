using Microsoft.AspNetCore.Mvc;
using Mushni_assigns.Models;

namespace Mushni_assigns.Controllers;
public class HomeController : Controller
{
    public ViewResult Index()
    {
        int hour = DateTime.Now.Hour;
        ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
        return View("MyView");
    }
    
    [HttpGet]
    public ViewResult StudentApplication() {
        return View();
    }
    
    [HttpPost]
    public ViewResult StudentApplication(StudentResponse studentResponse) {
        if (ModelState.IsValid) {
            Repository.AddResponse(studentResponse);
            return View("Thanks", studentResponse);
        } else {
            // there is a validation error
            return View();
        }
    }
    
    public ViewResult ListResponses() {
        return View(Repository.Responses);
    }
}