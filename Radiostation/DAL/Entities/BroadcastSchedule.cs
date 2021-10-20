﻿using System;


namespace RadiostationDAL.Entities
{
   public class BroadcastSchedule
    {
        public int Id { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int EmployeeId { get; set; }
        public int RecordId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Record Record { get; set; }
    }
}