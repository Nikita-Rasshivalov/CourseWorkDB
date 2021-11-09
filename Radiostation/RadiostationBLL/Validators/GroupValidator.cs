using FluentValidation;
using RadiostationBLL.ModelsDto;
using RadiostationDAL;
using RadiostationDAL.Entities;
using System.Linq;

namespace RadiostationBLL.Validators
{
    public class GroupValidator : AbstractValidator<GroupDto>
    {
        private readonly IRepository<Group> _groupRepository;

        public GroupValidator(IRepository<Group> groupRepository)
        {
            _groupRepository = groupRepository;

            RuleSet("Create", () =>
            {
                RuleFor(t => t.Description)
                    .Must(t => t != null && t != "")
                    .WithMessage("Description cannot be null or empty.");
            });

            RuleSet("Update", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsExistGroup(t.Id))
                    .WithMessage("There is no group  with this id.");
                RuleFor(t => t)
                    .Must(t => IsUniqueName(t))
                    .WithMessage("Group name must be unique.");

            });

            RuleSet("Delete", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsExistGroup(t.Id))
                    .WithMessage("There is no group with this id.");
            });
        }

        private bool IsUniqueName(GroupDto group)
        {
            var loadedGenres = _groupRepository.GetAll().Where(s => s.Id != group.Id);
            return loadedGenres.All(item => item.Description != group.Description);
        }

        private bool IsExistGroup(int id)
        {
            return _groupRepository.GetById(id) != null;
        }

    }
}
