using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RadiostationWeb.Data;
using RadiostationWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace RadiostationWeb.Controllers
{
    public class RecordController : Controller
    {
        private readonly RadiostationWebDbContext _dbContext;
        public RecordController(RadiostationWebDbContext context)
        {
            _dbContext = context;
        }

        [Authorize]
        public ActionResult Records(string nameFilter, int? performerFilter, int page = 1)
        {
            var pageSize = 10;
            var records = FilterRecords(nameFilter, performerFilter);
            var performers = _dbContext.Performers.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
            .ToList();
            var pageRecords = records.OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(records.Count(), page, pageSize);
            var viewRecords = pageRecords.ToList().Join(_dbContext.Performers.ToList(),
            e => e.PerformerId, t => t.Id,
            (e, t) => new RecordViewModel
            {
                Id = e.Id,
                PerformerName = t.Name,
                GenreId = e.GenreId,
                Album = e.Album,
                RecordDate = (e.RecordDate),
                Lasting = e.Lasting,
                Rating = e.Rating,
                СompositionName = e.СompositionName
            }).Join(_dbContext.Genres.ToList(), e => e.GenreId, t => t.Id,
            (e, t) => new RecordViewModel
            {
                Id = e.Id,
                PerformerName = e.PerformerName,
                GenreName = t.GenreName,
                Album = e.Album,
                RecordDate = e.RecordDate,
                Lasting = e.Lasting,
                Rating = e.Rating,
                СompositionName = e.СompositionName
            }
            );
            var pageItemsModel = new RecordsItemModel { Items = viewRecords, PageModel = pageViewModel, SelectPerformers = performers };
            return View(pageItemsModel);
        }

        public IActionResult ResetFilter()
        {

            HttpContext.Response.Cookies.Delete("nameFilter");
            HttpContext.Response.Cookies.Delete("performerFilter");
            return RedirectToAction(nameof(Records));
        }

        public IActionResult ResetManageFilter()
        {

            HttpContext.Response.Cookies.Delete("nameFilter");
            HttpContext.Response.Cookies.Delete("performerFilter");
            return RedirectToAction(nameof(ManageRecords));
        }
        private IQueryable<Record> FilterRecords(string nameFilter, int? performerFilter)
        {
            IQueryable<Record> records = _dbContext.Records;
            nameFilter = nameFilter ?? HttpContext.Request.Cookies["nameFilter"];
            if (!string.IsNullOrEmpty(nameFilter))
            {
                records = records.Where(e => e.СompositionName.Contains(nameFilter));
                HttpContext.Response.Cookies.Append("nameFilter", nameFilter);
            }
            int cookiePerformerFilter;
            int.TryParse(HttpContext.Request.Cookies["performerFilter"], out cookiePerformerFilter);
            performerFilter = performerFilter ?? cookiePerformerFilter;
            if (performerFilter != 0)
            {
                records = records.Where(e => e.PerformerId == performerFilter);
                HttpContext.Response.Cookies.Append("performerFilter", performerFilter.ToString());
            }
            return records;
        }


        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult ManageRecords(string nameFilter, int? performerFilter, int page = 1)
        {
            var pageSize = 10;
            var records = FilterRecords(nameFilter, performerFilter);
            var performers = _dbContext.Performers.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
            .ToList();
            var pageRecords = records.ToList().OrderBy(o => o.Id).Skip((page - 1) * pageSize).Take(pageSize);
            PageViewModel pageViewModel = new PageViewModel(records.Count(), page, pageSize);
            var viewRecords = pageRecords.ToList().Join(_dbContext.Performers.ToList(),
            e => e.PerformerId, t => t.Id,
            (e, t) => new RecordViewModel
            {
                Id = e.Id,
                PerformerName = t.Name,
                GenreId = e.GenreId,
                Album = e.Album,
                RecordDate = (e.RecordDate),
                Lasting = e.Lasting,
                Rating = e.Rating,
                СompositionName = e.СompositionName
            }).Join(_dbContext.Genres.ToList(), e => e.GenreId, t => t.Id,
            (e, t) => new RecordViewModel
            {
                Id = e.Id,
                PerformerName = e.PerformerName,
                GenreName = t.GenreName,
                Album = e.Album,
                RecordDate = e.RecordDate,
                Lasting = e.Lasting,
                Rating = e.Rating,
                СompositionName = e.СompositionName
            }
            );
            var pageItemsModel = new RecordsItemModel { Items = viewRecords, PageModel = pageViewModel,SelectPerformers = performers };
            return View(pageItemsModel);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Delete(int id)
        {
            var record = _dbContext.Records.Find(id);
            if (record != null)
            {
                try
                {
                    _dbContext.Records.Remove(record);
                    _dbContext.SaveChanges();
                }
                catch
                {
                    return RedirectToAction("Error", "Home",
                    new { message = "Record contain related data and cannot be deleted" });
                }
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "Record not found" });
            }

            return RedirectToAction(nameof(ManageRecords));
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Create()
        {
            var performers = _dbContext.Performers.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name})
            .ToList();

            var genres = _dbContext.Genres.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.GenreName })
            .ToList();
            return View(new CreateRecordViewModel { PerformersList = performers, GenresList = genres } );
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Create(CreateRecordViewModel record)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Records.Add(new Record 
                {
                    СompositionName = record.СompositionName,
                    Album=record.Album,
                    GenreId=record.GenreId,
                    Lasting=record.Lasting,
                    Rating=record.Rating,
                    RecordDate=record.RecordDate,
                    PerformerId=record.PerformerId
                });
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(ManageRecords));
            }

            return View(record);
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        public ActionResult Edit(int id)
        {
            var record = _dbContext.Records.Find(id);
            var performers = _dbContext.Performers.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name,
                Selected = record.PerformerId==c.Id
            }).ToList();

            var genres = _dbContext.Genres.Select(c => new SelectListItem 
            {
                Value = c.Id.ToString(),
                Text = c.GenreName,
                Selected = record.GenreId == c.Id
            }).ToList();
            if (record != null)
            {
                return View(new EditRecordViewModel
                { 
                    Id = id,
                    PerformersList = performers,
                    GenresList = genres,
                    Album = record.Album,
                    GenreId = record.GenreId,
                    PerformerId = record.PerformerId,
                    RecordDate = record.RecordDate,
                    Lasting = record.Lasting,
                    Rating = record.Rating,
                    СompositionName = record.СompositionName
                });
            }
            else
            {
                return RedirectToAction("Error", "Home",
                    new { message = "Record not found" });
            }
        }

        [AuthorizeRoles(RoleType.Admin, RoleType.Employeе)]
        [HttpPost]
        public ActionResult Edit(EditRecordViewModel record)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Records.Update(new Record
                {
                    Id = record.Id,
                    Album = record.Album,
                    GenreId=record.GenreId,
                    PerformerId = record.PerformerId,
                    RecordDate=record.RecordDate,
                    Lasting=record.Lasting,
                    Rating=record.Rating,
                    СompositionName=record.СompositionName
                });
                if (_dbContext.SaveChanges() != 0)
                {
                    ViewData["SuccessMessage"] = "Information has been successfully edited";
                    return RedirectToAction(nameof(ManageRecords));
                }
            }

            return View(record);
        }
    }
}
