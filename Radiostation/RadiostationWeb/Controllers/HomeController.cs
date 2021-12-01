using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RadiostationWeb.Data;
using RadiostationWeb.Models;

namespace RadiostationWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RadiostationWebDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, RadiostationWebDbContext dbContext, IWebHostEnvironment environment)
        {
            _logger = logger;
            _dbContext = dbContext;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_dbContext.HomePageImages);
        }


        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Create()
        {
            return View(new HomePageImage());
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public async Task<IActionResult> Create(IFormFile uploadedFile, HomePageImage image)
        {
            if (uploadedFile != null)
            {
               
                string path = "/img/" + uploadedFile.FileName;
                
                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                HomePageImage file = new HomePageImage { SrcImg = path,ImgCaption=image.ImgCaption };
                _dbContext.HomePageImages.Add(file);
                _dbContext.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Edit(int id)
        {
            var img = _dbContext.HomePageImages.Find(id);
            if (img != null)
            {
                return View(img);
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "img not found" });
            }
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Edit(HomePageImage img)
        {
            if (ModelState.IsValid)
            {
                _dbContext.HomePageImages.Update(img);
                if (_dbContext.SaveChanges() != 0)
                {
                    ViewData["SuccessMessage"] = "Information has been successfully edited";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(img);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Delete(int id)
        {
            var img = _dbContext.HomePageImages.Find(id);
            if (img != null)
            {
                try
                {
                    _dbContext.HomePageImages.Remove(img);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    return RedirectToAction("Error", "Home",
                    new { message = "img contain related data and cannot be deleted" });
                }
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "img not found" });
            }

            return RedirectToAction(nameof(Index));
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
