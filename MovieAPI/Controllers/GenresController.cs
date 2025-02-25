using Microsoft.AspNetCore.Mvc;
using MediatR;



namespace MovieAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GenresController : ControllerBase
{
    private readonly IMediator _mediator;

    public GenresController(IMediator mediator)
    {
        _mediator = mediator;
    }

  

    //[HttpPost("CreateGenre")]
    //public async Task<ActionResult<Result>> AnularRecarga(CreateGenresCommandHandler command)
    //{
    //    return await Mediator.Send(command);
    //}

}