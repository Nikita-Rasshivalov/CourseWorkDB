using Microsoft.AspNetCore.Mvc;
using RadiostationDAL.EntityFrameworkRepositories;
using System.Linq;


namespace RadiostationWeb.Controllers
{
    public class GenreController : Controller
    {
        private readonly RadiostationDbContext _dbContext;
        public GenreController(RadiostationDbContext context)
        {
            _dbContext = context;
        }


        public IActionResult Genres()
        {

            return View(_dbContext.Genres.ToList());
        }
    }
}
