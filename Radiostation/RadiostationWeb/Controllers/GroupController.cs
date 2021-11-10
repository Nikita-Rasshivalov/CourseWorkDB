using Microsoft.AspNetCore.Mvc;
using RadiostationDAL.EntityFrameworkRepositories;
using System.Linq;


namespace RadiostationWeb.Controllers
{
    public class GroupController : Controller
    {
        private readonly RadiostationDbContext _dbContext;
        public GroupController(RadiostationDbContext context)
        {
            _dbContext = context;
        }


        public IActionResult Groups()
        {
            return View(_dbContext.Groups.ToList());
        }
    }
}
