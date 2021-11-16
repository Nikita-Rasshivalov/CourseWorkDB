using Microsoft.EntityFrameworkCore;
using RadiostationWeb.Models;


namespace RadiostationWeb.Data
{
    public partial class BDLab1Context : DbContext
    {
        public BDLab1Context()
        {
        }

        public BDLab1Context(DbContextOptions<BDLab1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BroadcastSchedule> BroadcastSchedules { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Performer> Performers { get; set; }
        public virtual DbSet<Record> Records { get; set; }

    }
}
