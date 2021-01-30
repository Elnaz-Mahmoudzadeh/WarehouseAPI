namespace Server.Controllers
{
	[Microsoft.AspNetCore.Mvc.Route(template: "[controller]")]
	public class HomeController : Infrastructure.ApiControllerBase
    {
		public HomeController() : base()
		{
		}

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public string Get()
		{
			string message = "Hello, World!";

			return message;
		}
	}
}
