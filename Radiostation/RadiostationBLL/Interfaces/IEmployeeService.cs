using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq.Expressions;


namespace RadiostationBLL.Interfaces
{
    public interface IEmployeeService
    {

        ValidationResult CreateEmployee(EmployeeDto employeeDto);


        ValidationResult UpdateEmployee(EmployeeDto employeeDto);

        ValidationResult DeleteEmployee(EmployeeDto employeeDto);

        EmployeeDto GetEmployee(int employeeDto);


        List<EmployeeDto> GetEmployees();

        List<EmployeeDto> GetEmployeesBy(Expression<Func<Employee, bool>> predicate);
    }
}
