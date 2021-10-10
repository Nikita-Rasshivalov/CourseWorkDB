using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModelsLib
{
 public   class Group
    {
        public Group()
        {
            Performers = new HashSet<Performer>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Performer> Performers { get; set; }
    }
}
