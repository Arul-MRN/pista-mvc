using Microsoft.AspNetCore.Mvc;

namespace Pista.UI.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
}
