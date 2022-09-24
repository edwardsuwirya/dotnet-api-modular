using Microsoft.AspNetCore.Mvc;

namespace Shared.Controllers;

[Route("/api/[controller]")]
[Produces("application/json")]
[ApiController]
public class BaseController : ControllerBase
{
}