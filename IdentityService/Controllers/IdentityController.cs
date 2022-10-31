using Microsoft.AspNetCore.Mvc;

namespace Mchyll.IdentityService.Controllers
{
	[Route("api/identity")]
	[ApiController]
	public class IdentityController : ControllerBase
	{
		[HttpGet("Test")]
		public IActionResult Test()
		{
			return Ok("Hei");
		}
	}
}
