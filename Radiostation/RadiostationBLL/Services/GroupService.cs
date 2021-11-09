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
    public class GroupService : BaseService<GroupDto>, IGroupService
    {
        private readonly IRepository<Group> _groupRepository;


        public GroupService(IRepository<Group> groupRepository)
        {
            _groupRepository = groupRepository;
            Validator = new GroupValidator(groupRepository);
        }

        protected override AbstractValidator<GroupDto> Validator { get; set; }

        public ValidationResult CreateGroup(GroupDto groupDto)
        {
            var result = TryValidate(groupDto, "Create");
            if (result.IsValid)
            {
                var group = GetMapper().Map<GroupDto, Group>(groupDto);
                group.Id = _groupRepository.Create(group);
            }

            return result;
        }


        public ValidationResult UpdateGroup(GroupDto groupDto)
        {
            var result = TryValidate(groupDto, "Update");
            if (result.IsValid)
            {
                var group = GetMapper().Map<GroupDto, Group>(groupDto);
                _groupRepository.Update(group);
            }

            return result;
        }

        public ValidationResult DeleteGroup(GroupDto groupDto)
        {
            var result = TryValidate(groupDto, "Delete");
            if (result.IsValid)
            {
                var group = GetMapper().Map<GroupDto, Group>(groupDto);
                _groupRepository.Delete(group);
            }

            return result;
        }

        public GroupDto GetGroup(int groupId)
        {
            GroupDto groupDto = null;
            var group = _groupRepository.GetById(groupId);
            if (group != null)
            {
                groupDto = GetMapper().Map<Group, GroupDto>(group);
            }

            return groupDto;
        }


        public List<GroupDto> GetGroups()
        {
            var groups = _groupRepository.GetAll();
            var groupsDto = GetMapper().Map<IQueryable<Group>, List<GroupDto>>(groups) ?? new List<GroupDto>();

            return groupsDto;
        }


        public List<GroupDto> GetGroupsBy(Expression<Func<Group, bool>> predicate)
        {
            var groups = _groupRepository.GetAll().Where(predicate);
            var groupsDto = GetMapper().Map<IQueryable<Group>, List<GroupDto>>(groups) ?? new List<GroupDto>();

            return groupsDto;
        }
    }
}
