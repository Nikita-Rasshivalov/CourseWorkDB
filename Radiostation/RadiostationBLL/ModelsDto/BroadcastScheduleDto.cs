using System;

namespace RadiostationBLL.ModelsDto
{
   public class BroadcastScheduleDto
    {
        public int Id { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int EmployeeId { get; set; }
        public int RecordId { get; set; }

    }
}
