using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationDAL.EntityFrameworkRepositories
{
   public class GroupRepository:IRepository<Group>
    {
        private readonly RadiostationDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadiostationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">Access to database.</param>
        public GroupRepository(RadiostationDbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        /// <summary>
        /// Adds entity to Group table in MSSql database.
        /// </summary>
        /// <param name="entity">Group entity.</param>
        /// <returns>Added entity id if the operation was successful otherwise zero.</returns>
        public int Create(Group entity)
        {
            _dbContext.Groups.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Deletes entity from Groups table in MSSql database.
        /// </summary>
        /// <param name="entity">Group entity.</param>
        public void Delete(Group entity)
        {
            _dbContext.Groups.Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets all groups from Groups table in MSSql database.
        /// </summary>
        /// <returns>Group list if the operation was successful otherwise empty record list.</returns>
        public IQueryable<Group> GetAll()
        {
            return _dbContext.Groups.AsNoTracking();
        }

        /// <summary>
        /// Gets group entity from Groups table in MSSql database by specified id.
        /// </summary>
        /// <param name="id">Specified id of the group.</param>
        /// <returns>Group entity if the operation was successful otherwise null.</returns>
        public Group GetById(int id)
        {
            return _dbContext.Groups.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Updates entity in Groups table in MSSql database.
        /// </summary>
        /// <param name="entity">Group entity.</param>
        public void Update(Group entity)
        {
            _dbContext.Groups.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
