using Microsoft.AspNetCore.Mvc;
using Dojo_Surey_With_Validations.Models;
namespace Dojo_Surey_With_Validations.Controllers;
public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Home()
    {
        return View("Home");
    }

    [HttpPost("survey")]
    public IActionResult Result(Survey survey){
        if(ModelState.IsValid){
            return View("Result", survey);
        }
        else{
            return View("Home");
        }
    }
}

