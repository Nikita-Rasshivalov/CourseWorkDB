using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using RadiostationBLL.Mapper;
using System;
using System.Collections.Generic;



namespace RadiostationBLL.Interfaces
{
    /// <summary>
    /// Base service for services with try validation method.
    /// </summary>
    /// <typeparam name="T">Dto class.</typeparam>
    public abstract class BaseService<T>
    {
        private static MapperConfiguration _configuration =
            new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());


        protected abstract AbstractValidator<T> Validator { get; set; }

        public ValidationResult TryValidate(T entity, string ruleSetName)
        {
            ValidationResult result = null;
            try
            {
                result = Validator.Validate(entity, options => options.IncludeRuleSets(ruleSetName));
            }
            catch (Exception exception)
            {
                result ??= new ValidationResult(new List<ValidationFailure>());
                result.Errors.Add(new ValidationFailure("", exception.Message));
            }

            return result;
        }

        public IMapper GetMapper()
        {
            return _configuration.CreateMapper();
        }
    }
}
