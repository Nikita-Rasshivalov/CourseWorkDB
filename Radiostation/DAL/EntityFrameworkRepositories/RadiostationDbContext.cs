using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;



namespace RadiostationDAL.EntityFrameworkRepositories
{
    public partial class RadiostationDbContext : DbContext
    {
        public RadiostationDbContext()
        {
        }

        public RadiostationDbContext(DbContextOptions<RadiostationDbContext> options)
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
