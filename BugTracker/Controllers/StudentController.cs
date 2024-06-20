using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BugTracker.Controllers
{
    public class StudentController : Controller    
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }
    }
}

