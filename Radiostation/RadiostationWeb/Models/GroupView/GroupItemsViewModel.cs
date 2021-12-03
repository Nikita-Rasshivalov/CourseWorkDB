using System.Collections.Generic;

namespace RadiostationWeb.Models
{
    public class GroupItemsViewModel
    {
        public IEnumerable<GroupDetailViewModel> GroupsItems { get; set; }
        public string GroupName { get; set; }
    }
}
