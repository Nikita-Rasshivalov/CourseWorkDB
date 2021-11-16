using Microsoft.AspNetCore.Mvc;

namespace RadiostationWeb.Models
{
    public partial class Performer
    {

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? GroupId { get; set; }

    }
}
