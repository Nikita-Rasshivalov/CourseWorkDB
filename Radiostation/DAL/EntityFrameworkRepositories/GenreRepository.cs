using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationDAL.EntityFrameworkRepositories
{
   public class GenreRepository:IRepository<Genre>
    {
        private readonly RadiostationDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadiostationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">Access to database.</param>
        public GenreRepository(RadiostationDbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        /// <summary>
        /// Adds entity to Genre table in MSSql database.
        /// </summary>
        /// <param name="entity">Genre entity.</param>
        /// <returns>Added entity id if the operation was successful otherwise zero.</returns>
        public int Create(Genre entity)
        {
            _dbContext.Genres.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Deletes entity from Genres table in MSSql database.
        /// </summary>
        /// <param name="entity">Genre entity.</param>
        public void Delete(Genre entity)
        {
            _dbContext.Genres.Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets all Genres from Genres table in MSSql database.
        /// </summary>
        /// <returns>Genre list if the operation was successful otherwise empty record list.</returns>
        public IQueryable<Genre> GetAll()
        {
            return _dbContext.Genres.AsNoTracking();
        }

        /// <summary>
        /// Gets Genre entity from Genres table in MSSql database by specified id.
        /// </summary>
        /// <param name="id">Specified id of the Genre.</param>
        /// <returns>Genre entity if the operation was successful otherwise null.</returns>
        public Genre GetById(int id)
        {
            return _dbContext.Genres.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Updates entity in Genres table in MSSql database.
        /// </summary>
        /// <param name="entity">Genre entity.</param>
        public void Update(Genre entity)
        {
            _dbContext.Genres.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
