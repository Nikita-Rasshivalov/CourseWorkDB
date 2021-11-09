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
    public class GenreService : BaseService<GenreDto>, IGenreService
    {
        private readonly IRepository<Genre> _genreRepository;


        public GenreService(IRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
            Validator = new GenreValidator(genreRepository);
        }

        protected override AbstractValidator<GenreDto> Validator { get; set; }

        public ValidationResult CreateGenre(GenreDto genreDto)
        {
            var result = TryValidate(genreDto, "Create");
            if (result.IsValid)
            {
                var genre = GetMapper().Map<GenreDto, Genre>(genreDto);
                genre.Id = _genreRepository.Create(genre);
            }

            return result;
        }


        public ValidationResult UpdateGenre(GenreDto genreDto)
        {
            var result = TryValidate(genreDto, "Update");
            if (result.IsValid)
            {
                var genre = GetMapper().Map<GenreDto, Genre>(genreDto);
                _genreRepository.Update(genre);
            }

            return result;
        }

        public ValidationResult DeleteGenre(GenreDto genreDto)
        {
            var result = TryValidate(genreDto, "Delete");
            if (result.IsValid)
            {
                var genre = GetMapper().Map<GenreDto, Genre>(genreDto);
                _genreRepository.Delete(genre);
            }

            return result;
        }

        public GenreDto GetGenre(int genreId)
        {
            GenreDto genreDto = null;
            var genre = _genreRepository.GetById(genreId);
            if (genre != null)
            {
                genreDto = GetMapper().Map<Genre, GenreDto>(genre);
            }

            return genreDto;
        }


        public List<GenreDto> GetGenres()
        {
            var genres = _genreRepository.GetAll();
            var genresDto = GetMapper().Map<IQueryable<Genre>, List<GenreDto>>(genres) ?? new List<GenreDto>();

            return genresDto;
        }


        public List<GenreDto> GetGenresBy(Expression<Func<Genre, bool>> predicate)
        {
            var genres = _genreRepository.GetAll().Where(predicate);
            var genresDto = GetMapper().Map<IQueryable<Genre>, List<GenreDto>>(genres) ?? new List<GenreDto>();

            return genresDto;
        }
    }
}
