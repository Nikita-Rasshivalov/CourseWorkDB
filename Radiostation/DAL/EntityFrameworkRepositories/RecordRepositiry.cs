using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationDAL.EntityFrameworkRepositories
{

    /// <summary>
    /// Provides access to record entity in MSSql database via Entity Framework.
    /// </summary>
    public class RecordRepositiry : IRepository<Record>
    {
        private readonly RadiostationDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadiostationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">Access to database.</param>
        public RecordRepositiry(RadiostationDbContext dbcontext) {
            _dbContext = dbcontext;
        
        }
        /// <summary>
        /// Adds entity to Record table in MSSql database.
        /// </summary>
        /// <param name="entity">Record entity.</param>
        /// <returns>Added entity id if the operation was successful otherwise zero.</returns>
        public int Create(Record entity)
        {
            _dbContext.Records.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Deletes entity from Records table in MSSql database.
        /// </summary>
        /// <param name="entity">Record entity.</param>
        public void Delete(Record entity)
        {
            _dbContext.Records.Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets all records from Records table in MSSql database.
        /// </summary>
        /// <returns>Record list if the operation was successful otherwise empty record list.</returns>
        public IQueryable<Record> GetAll()
        {
            return _dbContext.Records.AsNoTracking();
        }

        /// <summary>
        /// Gets record entity from Records table in MSSql database by specified id.
        /// </summary>
        /// <param name="id">Specified id of the record.</param>
        /// <returns>Record entity if the operation was successful otherwise null.</returns>
        public Record GetById(int id)
        {
            return _dbContext.Records.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Updates entity in Records table in MSSql database.
        /// </summary>
        /// <param name="entity">Record entity.</param>
        public void Update(Record entity)
        {
            _dbContext.Records.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
