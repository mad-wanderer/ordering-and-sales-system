using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ordering_and_sales_system.Models;
using ordering_and_sales_system.Services;

namespace ordering_and_sales_system.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Views/Accounts/Login.cshtml");
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            PendingOrdersService pendingOrdersService = new PendingOrdersService(string.Empty);

            return RedirectToAction("Dashboard", "Home");

        }

        
    }
}
