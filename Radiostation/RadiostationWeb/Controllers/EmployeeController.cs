using Microsoft.AspNetCore.Mvc;
using RadiostationDAL.EntityFrameworkRepositories;
using System.Linq;

namespace RadiostationWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly RadiostationDbContext _dbContext;
        public EmployeeController(RadiostationDbContext context)
        {
            _dbContext = context;
        }


        public IActionResult Employees()
        {
            return View(_dbContext.Employees.ToList());
        }
    }
}

