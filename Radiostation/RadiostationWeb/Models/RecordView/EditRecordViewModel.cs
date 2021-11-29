using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace RadiostationWeb.Models
{
    public class EditRecordViewModel
    {
        public int Id { get; set; }
        public int PerformerId { get; set; }
        public int GenreId { get; set; }
        public string Album { get; set; }
        public DateTime RecordDate { get; set; }
        public int Lasting { get; set; }
        public decimal Rating { get; set; }
        public string СompositionName { get; set; }

        public IEnumerable<SelectListItem> PerformersList { get; set; }
        public IEnumerable<SelectListItem> GenresList { get; set; }
    }
}
