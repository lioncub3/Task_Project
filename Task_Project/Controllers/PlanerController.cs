using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_Project.Data;

namespace Task_Project.Controllers
{
    public class PlanerController : Controller
    {
        private TasksContext db;

        public PlanerController(TasksContext context)
        {
            this.db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask()
        {
            return View();
        }
    }
}