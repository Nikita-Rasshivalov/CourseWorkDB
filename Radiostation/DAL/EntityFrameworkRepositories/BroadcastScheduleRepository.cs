using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationDAL.EntityFrameworkRepositories
{
    public class BroadcastScheduleRepository:IRepository<BroadcastSchedule>
    {
        private readonly RadiostationDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadiostationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">Access to database.</param>
        public BroadcastScheduleRepository(RadiostationDbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        /// <summary>
        /// Adds entity to BroadcastSchedule table in MSSql database.
        /// </summary>
        /// <param name="entity">BroadcastSchedule entity.</param>
        /// <returns>Added entity id if the operation was successful otherwise zero.</returns>
        public int Create(BroadcastSchedule entity)
        {
            _dbContext.BroadcastSchedules.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Deletes entity from BroadcastSchedules table in MSSql database.
        /// </summary>
        /// <param name="entity">BroadcastSchedule entity.</param>
        public void Delete(BroadcastSchedule entity)
        {
            _dbContext.BroadcastSchedules.Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets all BroadcastSchedules from BroadcastSchedules table in MSSql database.
        /// </summary>
        /// <returns>BroadcastSchedule list if the operation was successful otherwise empty record list.</returns>
        public IQueryable<BroadcastSchedule> GetAll()
        {
            return _dbContext.BroadcastSchedules.AsNoTracking();
        }

        /// <summary>
        /// Gets BroadcastSchedule entity from BroadcastSchedules table in MSSql database by specified id.
        /// </summary>
        /// <param name="id">Specified id of the BroadcastSchedule.</param>
        /// <returns>BroadcastSchedule entity if the operation was successful otherwise null.</returns>
        public BroadcastSchedule GetById(int id)
        {
            return _dbContext.BroadcastSchedules.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Updates entity in BroadcastSchedules table in MSSql database.
        /// </summary>
        /// <param name="entity">BroadcastSchedule entity.</param>
        public void Update(BroadcastSchedule entity)
        {
            _dbContext.BroadcastSchedules.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
