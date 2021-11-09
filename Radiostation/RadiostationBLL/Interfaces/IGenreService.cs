using RadiostationBLL.ModelsDto;
using RadiostationDAL.Entities;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq.Expressions;


namespace RadiostationBLL.Interfaces
{
    public interface IGenreService
    {

        ValidationResult CreateGenre(GenreDto genreDto);


        ValidationResult UpdateGenre(GenreDto genreDto);

        ValidationResult DeleteGenre(GenreDto genreDto);

        GenreDto GetGenre(int genreDto);


        List<GenreDto> GetGenres();

        List<GenreDto> GetGenresBy(Expression<Func<Genre, bool>> predicate);
    }
}
