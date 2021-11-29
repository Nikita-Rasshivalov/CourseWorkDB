using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RadiostationWeb.Models
{
    public class CreatePerformerViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<SelectListItem> GroupsList { get; set; }
    }
}
