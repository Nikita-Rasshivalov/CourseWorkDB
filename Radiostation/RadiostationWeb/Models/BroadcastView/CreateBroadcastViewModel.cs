﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;


namespace RadiostationWeb.Models
{
    public class CreateBroadcastViewModel
    {
        public int EmployeeId { get; set; }
        public int RecordId { get; set; }
        public DateTime? DateAndTime { get; set; }

        public IEnumerable<SelectListItem> EmployeeList { get; set; }
        public IEnumerable<SelectListItem> RecordList { get; set; }
    }
}
