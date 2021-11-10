using Microsoft.AspNetCore.Mvc;
using RadiostationDAL.EntityFrameworkRepositories;
using RadiostationWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace RadiostationWeb.Controllers
{
    public class PerformerController : Controller
    {
        private readonly RadiostationDbContext _dbContext;
        public PerformerController(RadiostationDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Performers()
        {
            var performers = _dbContext.Performers.ToList();
            var viewPerformers = performers.Join(_dbContext.Groups.ToList(),
                e => e.GroupId, t => t.Id,
                (e, t) => new PerformerViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Surname = e.Surname,
                    GroupName = t.Description
                });
            return View(viewPerformers);

        }

    }
}
