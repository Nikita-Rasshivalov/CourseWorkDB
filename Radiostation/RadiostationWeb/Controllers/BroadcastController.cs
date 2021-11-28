using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadiostationWeb.Data;
using RadiostationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RadiostationWeb.Controllers
{
    public class BroadcastController : Controller
    {
        private readonly RadiostationWebDbContext _dbContext;
        private readonly ApplicationDbContext _applicationDbContext;
        public BroadcastController(RadiostationWebDbContext context, ApplicationDbContext applicationDbContext)
        {
            _dbContext = context;
            _applicationDbContext = applicationDbContext;
        }


        public ActionResult Broadcasts(DateTime? start, DateTime? end, int page = 1)
        {
            var pageSize = 20;
            var broadcasts = FilterBroadcasts(start, end).ToList();
            var pageBroadcasts = broadcasts.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(broadcasts.Count(), page, pageSize);
            var viewBroadcasts = from b in broadcasts
                                 join e in _dbContext.Employees.ToList() on b.EmployeeId equals e.Id
                                 join a in _applicationDbContext.Users.ToList() on e.AspNetUserId equals a.Id
                                 join r in _dbContext.Records on b.RecordId equals r.Id
                                 select new BroadcastViewModel
                                 {
                                     Id = b.Id,
                                     EmployeeName = a.Name,
                                     EmployeeSurname = a.Surname,
                                     DateAndTime = b.DateAndTime,
                                     RecordName = r.СompositionName
                                 };
            var pageItemsModel = new PageItemsModel<BroadcastViewModel> { Items = viewBroadcasts, PageModel = pageViewModel };
            return View(pageItemsModel);
        }

        public IActionResult ResetFilter()
        {
            HttpContext.Response.Cookies.Delete("broadcastsFrom");
            HttpContext.Response.Cookies.Delete("broadcastsTo");
            return RedirectToAction(nameof(Broadcasts));
        }

        public IActionResult ResetManageFilter()
        {

            HttpContext.Response.Cookies.Delete("broadcastsFrom");
            HttpContext.Response.Cookies.Delete("broadcastsTo");
            return RedirectToAction(nameof(ManageBroadcasts));
        }
        private IQueryable<Broadcast> FilterBroadcasts(DateTime? start, DateTime? end)
        {

            IQueryable<Broadcast> broadcasts = _dbContext.Broadcasts;
            var cookiesStringStart = HttpContext.Request.Cookies["broadcastsFrom"];
            var cookiesStringEnd = HttpContext.Request.Cookies["broadcastsTo"];
            DateTime? cookiesStart = null;
            DateTime? cookiesEnd = null;
            if (end is null && start is null && !string.IsNullOrEmpty(cookiesStringStart) && !string.IsNullOrEmpty(cookiesStringEnd))
            {
                cookiesStart = DateTime.Parse(cookiesStringStart);
                cookiesEnd = DateTime.Parse(cookiesStringEnd);
            }
            start ??= cookiesStart;
            end ??= cookiesEnd;
            if (start != null && end != null)
            {
                broadcasts = broadcasts.Where(e => e.DateAndTime > start && e.DateAndTime < end);
                HttpContext.Response.Cookies.Append("broadcastsFrom", start.ToString());
                HttpContext.Response.Cookies.Append("broadcastsTo", end.ToString());
            }
            return broadcasts;
        }


        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult ManageBroadcasts(string nameFilter, int? performerFilter, int page = 1)
        {
            var pageSize = 20;
            var broadcasts = _dbContext.Broadcasts.ToList();
            var pageBroadcasts = broadcasts.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(broadcasts.Count(), page, pageSize);
            var viewBroadcasts = from b in broadcasts
                                 join e in _dbContext.Employees.ToList() on b.EmployeeId equals e.Id
                                 join a in _applicationDbContext.Users.ToList() on e.AspNetUserId equals a.Id
                                 join r in _dbContext.Records on b.RecordId equals r.Id
                                 select new BroadcastViewModel
                                 {
                                     Id = b.Id,
                                     EmployeeName = a.Name,
                                     EmployeeSurname = a.Surname,
                                     DateAndTime = b.DateAndTime,
                                     RecordName = r.СompositionName

                                 };
            var pageItemsModel = new PageItemsModel<BroadcastViewModel> { Items = viewBroadcasts, PageModel = pageViewModel };
            return View(pageItemsModel);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Delete(int id)
        {
            var broadcast = _dbContext.Broadcasts.Find(id);
            if (broadcast != null)
            {
                try
                {
                    _dbContext.Broadcasts.Remove(broadcast);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    return RedirectToAction("Error", "Home",
                    new { message = "Broadcast contain related data and cannot be deleted" });
                }
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "Broadcast not found" });
            }

            return RedirectToAction(nameof(ManageBroadcasts));
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Create()
        {
            return View(new Broadcast());
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Create(Broadcast broadcast)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Broadcasts.Add(broadcast);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(ManageBroadcasts));
            }

            return View(broadcast);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Edit(int id)
        {
            var broadcast = _dbContext.Broadcasts.Find(id);
            if (broadcast != null)
            {
                return View(broadcast);
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "broadcast not found" });
            }
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Edit(Broadcast broadcast)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Broadcasts.Update(broadcast);
                if (_dbContext.SaveChanges() != 0)
                {
                    ViewData["SuccessMessage"] = "Information has been successfully edited";
                    return RedirectToAction(nameof(ManageBroadcasts));
                }
            }

            return View(broadcast);
        }
    }
}
