using FluentValidation;
using RadiostationBLL.Interfaces;
using RadiostationBLL.ModelsDto;
using RadiostationBLL.Validators;
using RadiostationDAL;
using RadiostationDAL.Entities;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace RadiostationBLL.Services
{
    public class EmployeeService : BaseService<EmployeeDto>, IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;


        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
            Validator = new EmployeeValidator(employeeRepository);
        }

        protected override AbstractValidator<EmployeeDto> Validator { get; set; }

        public ValidationResult CreateEmployee(EmployeeDto employeeDto)
        {
            var result = TryValidate(employeeDto, "Create");
            if (result.IsValid)
            {
                var employee = GetMapper().Map<EmployeeDto, Employee>(employeeDto);
                employee.Id = _employeeRepository.Create(employee);
            }

            return result;
        }


        public ValidationResult UpdateEmployee(EmployeeDto employeeDto)
        {
            var result = TryValidate(employeeDto, "Update");
            if (result.IsValid)
            {
                var employee = GetMapper().Map<EmployeeDto, Employee>(employeeDto);
                _employeeRepository.Update(employee);
            }

            return result;
        }

        public ValidationResult DeleteEmployee(EmployeeDto employeeDto)
        {
            var result = TryValidate(employeeDto, "Delete");
            if (result.IsValid)
            {
                var employee = GetMapper().Map<EmployeeDto, Employee>(employeeDto);
                _employeeRepository.Delete(employee);
            }

            return result;
        }

        public EmployeeDto GetEmployee(int employeeId)
        {
            EmployeeDto employeeDto = null;
            var employee = _employeeRepository.GetById(employeeId);
            if (employee != null)
            {
                employeeDto = GetMapper().Map<Employee, EmployeeDto>(employee);
            }

            return employeeDto;
        }


        public List<EmployeeDto> GetEmployees()
        {
            var employees = _employeeRepository.GetAll();
            var employeesDto = GetMapper().Map<IQueryable<Employee>, List<EmployeeDto>>(employees) ?? new List<EmployeeDto>();

            return employeesDto;
        }


        public List<EmployeeDto> GetEmployeesBy(Expression<Func<Employee, bool>> predicate)
        {
            var employees = _employeeRepository.GetAll().Where(predicate);
            var employeesDto = GetMapper().Map<IQueryable<Employee>, List<EmployeeDto>>(employees) ?? new List<EmployeeDto>();

            return employeesDto;
        }
    }
}
