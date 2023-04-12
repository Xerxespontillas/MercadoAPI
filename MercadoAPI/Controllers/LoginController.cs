using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoAPI.Model;

namespace MercadoAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class LoginController : ControllerBase
	{
		private readonly AppDBContext _dbContext;

		public LoginController(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		
		//: api/Login
		[HttpPost]
		public async Task<ActionResult<Login>> Login()
		{
			if (!Request.Headers.TryGetValue("Username", out var usernameValues))
			{
				return BadRequest("Username header is missing.");
			}

			if (!Request.Headers.TryGetValue("Password", out var passwordValues))
			{
				return BadRequest("Password header is missing.");
			}
			var username = usernameValues.FirstOrDefault();
			var password = passwordValues.FirstOrDefault();

			var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.username == username && u.password == password );
			if (user == null)
			{
				return NotFound();
			}
			return Ok(User);

		}



	}
}
