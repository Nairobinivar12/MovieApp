using Aplication.Interfaces;
using Domain.Entities;
using FluentResults;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class GenresServices : IGenres
    {
        private readonly AppDbContext _context;
        public GenresServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result<List<Genres>>> GetGenres()
        {
            var genres = await _context.genres.ToListAsync();

            if (genres == null || !genres.Any())
            {
                return Result.Fail("No se encontraron géneros.");
            }

            return Result.Ok(genres);
        }


        public async Task<Result<Genres>> GetGenresId(int id)
        {
            var genre = await _context.genres.FindAsync(id);

            if (genre == null)
            {
                return Result.Fail($"No se encontró un género con el ID {id}.");
            }

            return Result.Ok(genre);
        }


        public async Task<Result> CreateGenres(Genres genres)
        {
            if (genres == null)
            {
                return Result.Fail("El género no puede ser nulo.");
            }

            _context.genres.Add(genres);
            await _context.SaveChangesAsync();

            return Result.Ok().WithSuccess("Género creado exitosamente.");
        }

        public async Task<Result> UpdateGenres(int id, Genres updatedGenre)
        {
            var genre = await _context.genres.FindAsync(id);

            if (genre == null)
            {
                return Result.Fail($"No se encontró un género con el ID {id}.");
            }

            genre.Name = updatedGenre.Name;

            await _context.SaveChangesAsync();

            return Result.Ok().WithSuccess("Género actualizado exitosamente.");
        }

        public async Task<Result> DeleteGenres(int id)
        {
            var genre = await _context.genres.FindAsync(id);

            if (genre == null)
            {
                return Result.Fail($"No se encontró un género con el ID {id}.");
            }

            _context.genres.Remove(genre);
            await _context.SaveChangesAsync();

            return Result.Ok().WithSuccess("Género eliminado exitosamente.");
        }

    }
}
