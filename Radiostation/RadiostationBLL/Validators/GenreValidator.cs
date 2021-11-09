using FluentValidation;
using RadiostationBLL.ModelsDto;
using RadiostationDAL;
using RadiostationDAL.Entities;
using System.Linq;


namespace RadiostationBLL.Validators
{
    public class GenreValidator : AbstractValidator<GenreDto>
    {
        private readonly IRepository<Genre> _genreRepository;


        public GenreValidator(IRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
            RuleSet("Create", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsUniqueName(t))
                    .WithMessage("Genre name must be unique.");
            });

            RuleSet("Update", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsExistGenre(t.Id))
                    .WithMessage("There is no genre with this id.");
                RuleFor(t => t)
                    .Must(t => IsUniqueName(t))
                    .WithMessage("Genre name must be unique.");
            });

            RuleSet("Delete", () =>
            {
                RuleFor(t => t)
                    .Must(t => IsExistGenre(t.Id))
                    .WithMessage("There is no genre with this id.");
            });
        }


        private bool IsExistGenre(int genreId)
        {
            return _genreRepository.GetById(genreId) != null;
        }


        private bool IsUniqueName(GenreDto genre)
        {
            var loadedGenres = _genreRepository.GetAll().Where(s => s.Id != genre.Id);
            return loadedGenres.All(item => item.GenreName != genre.GenreName);
        }
    }
}
