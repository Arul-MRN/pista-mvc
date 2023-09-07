using Microsoft.AspNetCore.Mvc;

namespace Pista.UI.Controllers;

public class DashboardController : Controller
{


    public IActionResult Index()
    {

        return View();
    }


}