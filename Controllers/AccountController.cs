using E_Yoklama.Db;
using Microsoft.AspNetCore.Mvc;

namespace E_Yoklama.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataBase _context;

        public AccountController(DataBase context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name, string pw)
        {
            if ("öğretmen" == name && "123" == pw)
            {
                HttpContext.Session.SetString("id", "öğretmen");
                return RedirectToAction("Index", "Home");
            }
            else if ("öğrenci" == name && "123" == pw)
            {
                HttpContext.Session.SetString("id", "öğrenci");
                return RedirectToAction("Index", "Home");
            }
            else if ("öğrenci2" == name && "123" == pw)
            {
                HttpContext.Session.SetString("id", "öğrenci2");
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
