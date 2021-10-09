using System;
using System.Collections.Generic;

#nullable disable

namespace RadiostationWeb.Models
{
    public partial class Record
    {
        public Record()
        {
            BroadcastSchedules = new HashSet<BroadcastSchedule>();
        }

        public int Id { get; set; }
        public string СompositionName { get; set; }
        public int PerformerId { get; set; }
        public int GenreId { get; set; }
        public string Album { get; set; }
        public DateTime RecordDate { get; set; }
        public int Lasting { get; set; }
        public decimal Rating { get; set; }

        public virtual Performer Performer { get; set; }
        public virtual ICollection<BroadcastSchedule> BroadcastSchedules { get; set; }
    }
}
