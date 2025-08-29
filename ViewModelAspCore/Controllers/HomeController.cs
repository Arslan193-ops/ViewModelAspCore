using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelAspCore.Models;

namespace ViewModelAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Age = 20, Grade = "A" },
                new Student { Id = 2, Name = "Bob", Age = 22, Grade = "B" },
                new Student { Id = 3, Name = "Charlie", Age = 21, Grade = "C" }
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Id = 1, Name = "Mr. Smith", Subject = "Math", Experience = 10 },
                new Teacher { Id = 2, Name = "Ms. Johnson", Subject = "Science", Experience = 8 },
                new Teacher { Id = 3, Name = "Mrs. Brown", Subject = "History", Experience = 12 }
            };

            var schoolViewModel = new SchoolViewModel
            {
                Students = students,
                Teachers = teachers
            };
            return View(schoolViewModel);
        }

        public IActionResult About()
        {
          
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
