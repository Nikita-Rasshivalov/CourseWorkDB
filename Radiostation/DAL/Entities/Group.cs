
using System.Collections.Generic;


namespace RadiostationDAL.Entities
{
    public class Group
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
