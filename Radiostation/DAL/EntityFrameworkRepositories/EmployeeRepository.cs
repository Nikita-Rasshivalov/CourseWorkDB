using Microsoft.EntityFrameworkCore;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationDAL.EntityFrameworkRepositories
{
   public class EmployeeRepository:IRepository<Employee>
    {
        private readonly RadiostationDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RadiostationDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">Access to database.</param>
        public EmployeeRepository(RadiostationDbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        /// <summary>
        /// Adds entity to Employee table in MSSql database.
        /// </summary>
        /// <param name="entity">Employee entity.</param>
        /// <returns>Added entity id if the operation was successful otherwise zero.</returns>
        public int Create(Employee entity)
        {
            _dbContext.Employees.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        /// <summary>
        /// Deletes entity from Employees table in MSSql database.
        /// </summary>
        /// <param name="entity">Employee entity.</param>
        public void Delete(Employee entity)
        {
            _dbContext.Employees.Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Gets all Employees from Employees table in MSSql database.
        /// </summary>
        /// <returns>Employee list if the operation was successful otherwise empty record list.</returns>
        public IQueryable<Employee> GetAll()
        {
            return _dbContext.Employees.AsNoTracking();
        }

        /// <summary>
        /// Gets Employee entity from Employees table in MSSql database by specified id.
        /// </summary>
        /// <param name="id">Specified id of the Employee.</param>
        /// <returns>Employee entity if the operation was successful otherwise null.</returns>
        public Employee GetById(int id)
        {
            return _dbContext.Employees.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Updates entity in Employees table in MSSql database.
        /// </summary>
        /// <param name="entity">Employee entity.</param>
        public void Update(Employee entity)
        {
            _dbContext.Employees.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
