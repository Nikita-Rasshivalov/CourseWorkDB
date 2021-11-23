using System;
namespace RadiostationWeb.Models
{
    public partial class Broadcast
    {
        public int Id { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int EmployeeId { get; set; }
        public int RecordId { get; set; }

    }
}
