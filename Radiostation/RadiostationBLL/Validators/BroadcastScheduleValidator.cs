using FluentValidation;
using RadiostationBLL.ModelsDto;
using RadiostationDAL;
using RadiostationDAL.Entities;
using System;

namespace RadiostationBLL.Validators
{
    public class BroadcastScheduleValidator: AbstractValidator<BroadcastScheduleDto>
    {
        private readonly IRepository<BroadcastSchedule> _broadcastScheduleRepository;

        public BroadcastScheduleValidator(IRepository<BroadcastSchedule> broadcastScheduleRepository)
        {
            _broadcastScheduleRepository = broadcastScheduleRepository;


            RuleSet("Create", () =>
            {
                RuleFor(t => t.DateAndTime)
                    .Must(t => t != DateTime.MinValue)
                    .WithMessage("Date and time cannot be empty.");
            });

            RuleSet("Update", () =>
            {
                RuleFor(a => a.Id)
                    .Must(id => IsExistBrdcst(id))
                    .WithMessage("There is no broadcast schedule with this id.");
            });

            RuleSet("Delete", () =>
            {
                RuleFor(a => a.Id)
                    .Must(id => IsExistBrdcst(id))
                    .WithMessage("There is no broadcast schedule with this id.");
            });
        }
        private bool IsExistBrdcst(int id)
        {
            return _broadcastScheduleRepository.GetById(id) != null;
        }
    }
}
