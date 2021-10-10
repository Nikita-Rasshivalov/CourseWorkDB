using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModelsLib
{
    public class Employee
    {
        public Employee()
        {
            BroadcastSchedules = new HashSet<BroadcastSchedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }

        public virtual ICollection<BroadcastSchedule> BroadcastSchedules { get; set; }
    }
}
