using RadiostationDAL;
using RadiostationDAL.Entities;
using FluentValidation;
using RadiostationBLL.ModelsDto;

namespace RadiostationBLL.Validators
{
    public class PerformerValidator : AbstractValidator<PerformerDto>
    {
        private readonly IRepository<Performer> _performerRepository;

        public PerformerValidator(IRepository<Performer> performerRepository)
        {
            _performerRepository = performerRepository;

            RuleSet("Create", () =>
            {
                RuleFor(t => t.Name)
                    .Must(t => t != null && t != "")
                    .WithMessage("Name cannot be null or empty.");
                RuleFor(t => t.Surname)
                    .Must(t => t != null && t != "")
                    .WithMessage("Surname cannot be null or empty.");
            });

            RuleSet("Update", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsExistPerformer(t.Id))
                    .WithMessage("There is no performer  with this id.");
                
            });

            RuleSet("Delete", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsExistPerformer(t.Id))
                    .WithMessage("There is no performer with this id.");
            });
        }

   
        private bool IsExistPerformer(int performerId)
        {
            return _performerRepository.GetById(performerId) != null;
        }

    
    }
}
