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
    public class BroadcastScheduleService : BaseService<BroadcastScheduleDto>, IBroadcastScheduleService
    {
        private readonly IRepository<BroadcastSchedule> _broadcastScheduleRepository;


        public BroadcastScheduleService(IRepository<BroadcastSchedule> broadcastScheduleRepository)
        {
            _broadcastScheduleRepository = broadcastScheduleRepository;
            Validator = new BroadcastScheduleValidator(broadcastScheduleRepository);
        }

        protected override AbstractValidator<BroadcastScheduleDto> Validator { get; set; }

        public ValidationResult CreateBroadcastSchedule(BroadcastScheduleDto broadcastScheduleDto)
        {
            var result = TryValidate(broadcastScheduleDto, "Create");
            if (result.IsValid)
            {
                var broadcastSchedule = GetMapper().Map<BroadcastScheduleDto, BroadcastSchedule>(broadcastScheduleDto);
                broadcastSchedule.Id = _broadcastScheduleRepository.Create(broadcastSchedule);
            }

            return result;
        }


        public ValidationResult UpdateBroadcastSchedule(BroadcastScheduleDto broadcastScheduleDto)
        {
            var result = TryValidate(broadcastScheduleDto, "Update");
            if (result.IsValid)
            {
                var broadcastSchedule = GetMapper().Map<BroadcastScheduleDto, BroadcastSchedule>(broadcastScheduleDto);
                _broadcastScheduleRepository.Update(broadcastSchedule);
            }

            return result;
        }

        public ValidationResult DeleteBroadcastSchedule(BroadcastScheduleDto broadcastScheduleDto)
        {
            var result = TryValidate(broadcastScheduleDto, "Delete");
            if (result.IsValid)
            {
                var broadcastSchedule = GetMapper().Map<BroadcastScheduleDto, BroadcastSchedule>(broadcastScheduleDto);
                _broadcastScheduleRepository.Delete(broadcastSchedule);
            }

            return result;
        }

        public BroadcastScheduleDto GetBroadcastSchedule(int broadcastScheduleId)
        {
            BroadcastScheduleDto broadcastScheduleDto = null;
            var broadcastSchedule = _broadcastScheduleRepository.GetById(broadcastScheduleId);
            if (broadcastSchedule != null)
            {
                broadcastScheduleDto = GetMapper().Map<BroadcastSchedule, BroadcastScheduleDto>(broadcastSchedule);
            }

            return broadcastScheduleDto;
        }


        public List<BroadcastScheduleDto> GetBroadcastSchedules()
        {
            var broadcastSchedules = _broadcastScheduleRepository.GetAll();
            var broadcastSchedulesDto = GetMapper().Map<IQueryable<BroadcastSchedule>, List<BroadcastScheduleDto>>(broadcastSchedules) ?? new List<BroadcastScheduleDto>();

            return broadcastSchedulesDto;
        }


        public List<BroadcastScheduleDto> GetBroadcastSchedulesBy(Expression<Func<BroadcastSchedule, bool>> predicate)
        {
            var broadcastSchedules = _broadcastScheduleRepository.GetAll().Where(predicate);
            var broadcastSchedulesDto = GetMapper().Map<IQueryable<BroadcastSchedule>, List<BroadcastScheduleDto>>(broadcastSchedules) ?? new List<BroadcastScheduleDto>();

            return broadcastSchedulesDto;
        }
    }
}
