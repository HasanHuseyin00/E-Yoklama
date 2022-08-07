using E_Yoklama.Db;
using E_Yoklama.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Yoklama.Controllers
{
    [UserFilter]
    public class TeacherController : Controller
    {
        private readonly DataBase _context;

        public TeacherController(DataBase context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Lesson"] = new SelectList(_context.Lesson, "LessonId", "LessonName");
            //ViewBag.Lesson = new SelectList(_context.Lesson, "LessonId", "LessonName");
            return View();
        }
    }
}
