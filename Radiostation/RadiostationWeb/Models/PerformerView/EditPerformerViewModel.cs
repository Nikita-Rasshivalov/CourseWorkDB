using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RadiostationWeb.Models
{
    public class EditPerformerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? GroupId { get; set; }
        public IEnumerable<SelectListItem> GroupsList { get; set; }
    }
}
