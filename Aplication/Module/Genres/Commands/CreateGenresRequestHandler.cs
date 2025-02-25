using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Module.Genres.Commands
{
    public class CreateGenresRequestHandler :IRequest<Result>
    {
        public string Name { get; set; }
    }
}
