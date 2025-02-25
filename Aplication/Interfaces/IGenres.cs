using Domain.Entities;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
     public interface IGenres   
    {
        public Task<Result<List<Genres>>> GetGenres();
        public Task<Result<Genres>> GetGenresId(int id);
        public Task<Result>  CreateGenres(Genres genres);
        public Task<Result> UpdateGenres(int id, Genres updatedGenre);
        public Task<Result> DeleteGenres(int id);

    }
}
