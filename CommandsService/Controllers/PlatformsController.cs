using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{

	[ApiController]
	[Route("api/c/[controller]")]
	public class PlatformsController : ControllerBase
	{
		public PlatformsController()
		{
		}

		[HttpPost]
		public ActionResult TestinboundConnection ()
		{
			Console.WriteLine("-> Inbound POST # CommandService");
			return Ok("Inbound test from c platfrom controller");
		}
	}
}

