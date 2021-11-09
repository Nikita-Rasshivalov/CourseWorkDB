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
    public class PerformerService : BaseService<PerformerDto>, IPerformerService
    {
        private readonly IRepository<Performer> _performerRepository;


        public PerformerService(IRepository<Performer> performerRepository)
        {
            _performerRepository = performerRepository;
            Validator = new PerformerValidator(performerRepository);
        }

        protected override AbstractValidator<PerformerDto> Validator { get; set; }

        public ValidationResult CreatePerformer(PerformerDto performerDto)
        {
            var result = TryValidate(performerDto, "Create");
            if (result.IsValid)
            {
                var performer = GetMapper().Map<PerformerDto, Performer>(performerDto);
                performer.Id = _performerRepository.Create(performer);
            }

            return result;
        }


        public ValidationResult UpdatePerformer(PerformerDto performerDto)
        {
            var result = TryValidate(performerDto, "Update");
            if (result.IsValid)
            {
                var performer = GetMapper().Map<PerformerDto, Performer>(performerDto);
                _performerRepository.Update(performer);
            }

            return result;
        }

        public ValidationResult DeletePerformer(PerformerDto performerDto)
        {
            var result = TryValidate(performerDto, "Delete");
            if (result.IsValid)
            {
                var performer = GetMapper().Map<PerformerDto, Performer>(performerDto);
                _performerRepository.Delete(performer);
            }

            return result;
        }

        public PerformerDto GetPerformer(int performerId)
        {
            PerformerDto performerDto = null;
            var performer = _performerRepository.GetById(performerId);
            if (performer != null)
            {
                performerDto = GetMapper().Map<Performer, PerformerDto>(performer);
            }

            return performerDto;
        }


        public List<PerformerDto> GetPerformers()
        {
            var performers = _performerRepository.GetAll();
            var performersDto = GetMapper().Map<IQueryable<Performer>, List<PerformerDto>>(performers) ?? new List<PerformerDto>();

            return performersDto;
        }


        public List<PerformerDto> GetPerformersBy(Expression<Func<Performer, bool>> predicate)
        {
            var performers = _performerRepository.GetAll().Where(predicate);
            var performersDto = GetMapper().Map<IQueryable<Performer>, List<PerformerDto>>(performers) ?? new List<PerformerDto>();

            return performersDto;
        }
    }
}
