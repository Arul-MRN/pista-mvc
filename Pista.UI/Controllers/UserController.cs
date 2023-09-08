using Microsoft.AspNetCore.Mvc;
using Pista.UI.Models;

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

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(UserViewModel model)
    {
        if (ModelState.IsValid)
        {

        }
        return View();
    }
}
