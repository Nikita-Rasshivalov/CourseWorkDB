using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq.Expressions;


namespace RadiostationBLL.Interfaces
{
    public interface IGroupService
    {

        ValidationResult CreateGroup(GroupDto groupDto);


        ValidationResult UpdateGroup(GroupDto groupDto);

        ValidationResult DeleteGroup(GroupDto groupDto);

        GroupDto GetGroup(int groupDto);


        List<GroupDto> GetGroups();

        List<GroupDto> GetGroupsBy(Expression<Func<Group, bool>> predicate);
    }
}
