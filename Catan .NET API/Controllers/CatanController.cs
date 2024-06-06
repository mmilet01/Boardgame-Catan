using Catan.DomainClasses;
using Microsoft.AspNetCore.Mvc;

namespace Catan.Controllers;

[ApiController]
[Route("[controller]")]
public class CatanController : ControllerBase
{
    private readonly ILogger<CatanController> _logger;

    public CatanController(ILogger<CatanController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public ActionResult<Board> GetBoard()
    {
        var board = new Board();
        return Ok(board);
    }
}
