using Microsoft.AspNetCore.Mvc;

namespace Pista.UI.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
