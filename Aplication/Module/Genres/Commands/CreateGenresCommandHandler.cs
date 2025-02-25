using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using FluentResults;
using Aplication.Interfaces;
using GenresEntity = Domain.Entities.Genres;

namespace Aplication.Module.Genres.Commands
{
    public class CreateGenresCommandHandler : IRequestHandler<CreateGenresRequestHandler, Result>
    {
        private readonly IGenres _genres;

        public CreateGenresCommandHandler(IGenres genres)
        {
            _genres = genres;
        }

        public async Task<Result> Handle(CreateGenresRequestHandler request, CancellationToken cancellationToken)
        {

            var genre = new GenresEntity
            {
                Name = request.Name
            };

            await _genres.CreateGenres(genre);
            return Result.Ok();

        }
    }

}
