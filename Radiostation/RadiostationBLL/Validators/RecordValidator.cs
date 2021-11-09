using FluentValidation;
using RadiostationBLL.ModelsDto;
using RadiostationDAL;
using RadiostationDAL.Entities;
using System;


namespace RadiostationBLL.Validators
{
    public class RecordValidator : AbstractValidator<RecordDto>
    {
        private readonly IRepository<Record> _recordRepository;
        private readonly IRepository<Performer> _performerRepository;
        private readonly IRepository<Genre> _genreRepository;

        public RecordValidator(IRepository<Record> recordRepository, IRepository<Genre> genreRepository,
            IRepository<Performer> performerRepository)
        {
            _recordRepository = recordRepository;
            _performerRepository = performerRepository;
            _genreRepository = genreRepository;
            RuleSet("Create", () =>
            {
                RuleFor(t => t.GenreId)
                    .Must(genreId => IsExistGenre(genreId))
                    .WithMessage("There is no genre for this record.");

                RuleFor(t => t.PerformerId)
                    .Must(performerId => IsExistPerformer(performerId))
                    .WithMessage("There is no performer for this record.");

                RuleFor(t => t.Lasting)
                    .Must(t => t != 0)
                    .WithMessage("Lasting cannot be empty.");

                RuleFor(t => t.RecordDate)
                    .Must(t => t != DateTime.MinValue)
                    .WithMessage("Date cannot be empty.");

                RuleFor(t => t.СompositionName)
                    .Must(t => t != null && t != " ")
                    .WithMessage("Composition name cannot be empty.");

            });

            RuleSet("Update", () =>
            {
                RuleFor(a => a.Id)
                    .Must(id => IsExistRecord(id))
                    .WithMessage("There is no record with this id.");
                RuleFor(t => t.GenreId)
                    .Must(genreId => IsExistGenre(genreId))
                    .WithMessage("There is no genre for this record.");
                RuleFor(t => t.PerformerId)
                    .Must(performerId => IsExistPerformer(performerId))
                    .WithMessage("There is no performer for this record.");
            });

            RuleSet("Delete", () =>
            {
                RuleFor(a => a.Id)
                    .Must(id => IsExistRecord(id))
                    .WithMessage("There is no record with this id.");
            });
        }


        private bool IsExistRecord(int recordId)
        {
            return _recordRepository.GetById(recordId) != null;
        }

        private bool IsExistGenre(int genreId)
        {
            return _genreRepository.GetById(genreId) != null;
        }

        private bool IsExistPerformer(int performerId)
        {
            return _performerRepository.GetById(performerId) != null;
        }
    }
}
