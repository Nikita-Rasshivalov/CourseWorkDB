using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq.Expressions;


namespace RadiostationBLL.Interfaces
{
    public interface IBroadcastScheduleService
    {

        ValidationResult CreateBroadcastSchedule(BroadcastScheduleDto broadcastScheduleDto);


        ValidationResult UpdateBroadcastSchedule(BroadcastScheduleDto broadcastScheduleDto);

        ValidationResult DeleteBroadcastSchedule(BroadcastScheduleDto broadcastScheduleDto);

        BroadcastScheduleDto GetBroadcastSchedule(int broadcastScheduleDto);

        List<BroadcastScheduleDto> GetBroadcastSchedules();

        List<BroadcastScheduleDto> GetBroadcastSchedulesBy(Expression<Func<BroadcastSchedule, bool>> predicate);
    }
}
