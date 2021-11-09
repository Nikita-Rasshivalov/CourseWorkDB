using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq.Expressions;


namespace RadiostationBLL.Interfaces
{
    public interface IPerformerService
    {

        ValidationResult CreatePerformer(PerformerDto performerDto);


        ValidationResult UpdatePerformer(PerformerDto performerDto);

        ValidationResult DeletePerformer(PerformerDto performerDto);

        PerformerDto GetPerformer(int performerDto);


        List<PerformerDto> GetPerformers();

        List<PerformerDto> GetPerformersBy(Expression<Func<Performer, bool>> predicate);
    }
}
