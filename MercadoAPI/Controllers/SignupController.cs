using MercadoAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MercadoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public SignupController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Signup
        [HttpGet]
        public async Task<ActionResult<Signup>> GetUser()
        {
            var user= await _dbContext.Users.FindAsync();
			if (user== null)
			{
				return NotFound();
			}
            return user;
		}

        [HttpPost]
        public async Task<ActionResult<Signup>> PostSignup(Signup signup)
        {
			
			_dbContext.Users.Add(signup);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = signup.Id }, signup);
        }
    }
}
