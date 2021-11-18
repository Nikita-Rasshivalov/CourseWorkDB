using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadiostationWeb.Data;
using RadiostationWeb.Models;
using System.Linq;

namespace RadiostationWeb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly BDLab1Context _dbContext;
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeController(BDLab1Context context, ApplicationDbContext applicationDbContext)
        {
            _dbContext = context;
            _applicationDbContext = applicationDbContext;
        }


        [Authorize]
        public ActionResult Employees(int page = 1)
        {
            var pageSize = 20;
            var employees = _dbContext.Employees.ToList();
            var pageEmployees = employees.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(employees.Count(), page, pageSize);
            var viewEmployees = pageEmployees.Join(_applicationDbContext.Users.ToList(),
                e => e.AspNetUserId, t => t.Id,
                (e, t) => new EmployeeViewModel
                {
                    Id = e.Id,
                    AspNetUserId = t.Id,
                    Name = t.Name,
                    Surname = t.Surname,
                    MiddleName = t.MiddleName,
                    Username = t.UserName,
                    Email=t.Email
                });
            var pageItemsModel = new PageItemsModel<EmployeeViewModel> { Items = viewEmployees, PageModel = pageViewModel };
            return View(pageItemsModel);
        }
    }
}

