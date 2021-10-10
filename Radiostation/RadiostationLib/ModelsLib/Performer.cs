using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiostationLib.ModelsLib
{
   public class Performer
    {
        public Performer()
        {
            Records = new HashSet<Record>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
