using FluentValidation;
using RadiostationBLL.ModelsDto;
using RadiostationDAL;
using RadiostationDAL.Entities;


namespace RadiostationBLL.Validators
{
 
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
        private readonly IRepository<Employee> _employeeRepository;



        public EmployeeValidator(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;

            RuleSet("Create", () =>
            {
                RuleFor(t => t.Name)
                    .Must(t => t != null && t != "")
                    .WithMessage("Name cannot be null or empty.");
                RuleFor(t => t.Surname)
                    .Must(t => t != null && t != "")
                    .WithMessage("Surname cannot be null or empty.");
            });

            RuleSet("Update", () =>
            {
                RuleFor(t => t.Id)
                    .Must(id => IsExistEmployee(id))
                    .WithMessage("There is no employee with this id.");
                RuleFor(t => t.Name)
                    .Must(t => t != null && t != "")
                    .WithMessage("Name cannot be null or empty.");
                RuleFor(t => t.Surname)
                    .Must(t => t != null && t != "")
                    .WithMessage("Surname cannot be null or empty.");
            });

            RuleSet("Delete", () =>
            {
                RuleFor(t => t.Id)
                    .Must(id => IsExistEmployee(id))
                    .WithMessage("There is no employee with this id.");
            });
        }

        private bool IsExistEmployee(int employeeId)
        {
            return _employeeRepository.GetById(employeeId) != null;
        }
    }
}
