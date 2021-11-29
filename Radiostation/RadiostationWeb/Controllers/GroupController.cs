﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadiostationWeb.Data;
using RadiostationWeb.Models;
using System.Linq;


namespace RadiostationWeb.Controllers
{
    public class GroupController : Controller
    {
        private readonly RadiostationWebDbContext _dbContext;
        public GroupController(RadiostationWebDbContext context)
        {
            _dbContext = context;
        }

        [Authorize]
        public ActionResult Groups(string groupFilter, int page = 1)
        {
            var pageSize = 20;
            var groups = FilterGroups(groupFilter);
            var pageGroups = groups.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(groups.Count(), page, pageSize);
            var viewGroups = pageGroups.ToList();

            var pageItemsModel = new PageItemsModel<Group> { Items = viewGroups, PageModel = pageViewModel };
            return View(pageItemsModel);
        }

        [Authorize]
        public ActionResult GroupDetail(int id)
        {
            var groupDetail = _dbContext.Performers.ToList();
            var groupPage = _dbContext.Groups.FirstOrDefault(o => o.Id.Equals(id)).Description;
            var viewDetails = from p in groupDetail
                              join g in _dbContext.Groups.ToList() on p.GroupId equals g.Id
                              where g.Id.Equals(id)
                              select new GroupDetailView
                              {
                                  PerformerName = p.Name,
                                  PerformerSurname = p.Surname,
                                  GroupName = g.Description
                              };
            return View(new GroupItemsViewModel { GroupsItems = viewDetails,GroupName= groupPage });
        }

        public IActionResult ResetFilter()
        {

            HttpContext.Response.Cookies.Delete("groupFilter");
            return RedirectToAction(nameof(Groups));

        }
        private IQueryable<Group> FilterGroups(string groupFilter)
        {
            IQueryable<Group> groups = _dbContext.Groups;
            groupFilter = groupFilter ?? HttpContext.Request.Cookies["groupFilter"];
            if (!string.IsNullOrEmpty(groupFilter))
            {
                groups = groups.Where(e => e.Description.Contains(groupFilter));
                HttpContext.Response.Cookies.Append("groupFilter", groupFilter);
            }
            return groups;
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult ManageGroups(int page = 1)
        {
            IQueryable<Group> groups = _dbContext.Groups;
            var pageSize = 20;
            var pageGroups = groups.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(groups.Count(), page, pageSize);
            var viewGroups = pageGroups.ToList();
            var pageItemsModel = new PageItemsModel<Group> { Items = viewGroups, PageModel = pageViewModel };
            return View(pageItemsModel);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Delete(int id)
        {
            var group = _dbContext.Groups.Find(id);
            if (group != null)
            {
                try
                {
                    _dbContext.Groups.Remove(group);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    return RedirectToAction("Error", "Home",
                    new { message = "Group contain related data and cannot be deleted" });
                }
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "Group not found" });
            }

            return RedirectToAction(nameof(ManageGroups));
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Create()
        {
            return View(new Group());
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Create(Group group)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Groups.Add(group);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(ManageGroups));
            }

            return View(group);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Edit(int id)
        {
            var group = _dbContext.Groups.Find(id);
            if (group != null)
            {
                return View(group);
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "Group not found" });
            }
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Edit(Group group)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Groups.Update(group);
                if (_dbContext.SaveChanges() != 0)
                {
                    ViewData["SuccessMessage"] = "Information has been successfully edited";
                    return RedirectToAction(nameof(ManageGroups));
                }
            }

            return View(group);
        }

    }
}
