using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationDAL.EntityFrameworkRepositories
{
    public class PerformerRepository:IRepository<Performer>
    {
        private readonly RadiostationDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadiostationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">Access to database.</param>
        public PerformerRepository(RadiostationDbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        /// <summary>
        /// Adds entity to Performer table in MSSql database.
        /// </summary>
        /// <param name="entity">Performer entity.</param>
        /// <returns>Added entity id if the operation was successful otherwise zero.</returns>
        public int Create(Performer entity)
        {
            _dbContext.Performers.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Deletes entity from Performers table in MSSql database.
        /// </summary>
        /// <param name="entity">Performer entity.</param>
        public void Delete(Performer entity)
        {
            _dbContext.Performers.Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets all performers from Performers table in MSSql database.
        /// </summary>
        /// <returns>Performer list if the operation was successful otherwise empty record list.</returns>
        public IQueryable<Performer> GetAll()
        {
            return _dbContext.Performers.AsNoTracking();
        }

        /// <summary>
        /// Gets performer entity from Performers table in MSSql database by specified id.
        /// </summary>
        /// <param name="id">Specified id of the performer.</param>
        /// <returns>Performer entity if the operation was successful otherwise null.</returns>
        public Performer GetById(int id)
        {
            return _dbContext.Performers.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Updates entity in Performers table in MSSql database.
        /// </summary>
        /// <param name="entity">Performer entity.</param>
        public void Update(Performer entity)
        {
            _dbContext.Performers.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
