using Microsoft.AspNetCore.Mvc;

namespace TestService.Controllers
{
	[Route("api")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[HttpGet("Test")]
		public ActionResult<string> Test()
		{
			return "Hei";
		}
	}
}
