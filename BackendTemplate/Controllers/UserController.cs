using BackendTemplate.Models;
using BackendTemplate.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BackendTemplate.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class UserController : ControllerBase
    {
        private readonly APIDbContext _context;


        public UserController(APIDbContext context)
        {
            _context = context;
        }

        [MapToApiVersion("1.0")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserData(int id)
        {
            // Check if the user exists
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }


            return NoContent();
        }
    }
}
