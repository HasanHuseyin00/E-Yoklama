using E_Yoklama.Helper;
using Microsoft.AspNetCore.Mvc;

namespace E_Yoklama.Controllers
{
    [UserFilter]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
