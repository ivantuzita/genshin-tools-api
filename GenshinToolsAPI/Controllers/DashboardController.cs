using GenshinToolsAPI.Data;
using GenshinToolsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenshinToolsAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase {

        private readonly GenshinContext _dbContext;

        public DashboardController(GenshinContext dbContext) {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public IActionResult getUserCharactersById(int id) {
            var user = _dbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            if (user == null) {
                //returns 404
                return NotFound(new { Message = "User not found or has no characters!" });
            }
            //gets a list of characterid's using the user id as reference
            IEnumerable<int> characters = _dbContext.UserCharacters.Where(x => x.UserId == id)
                .Select(c => c.CharacterId).ToList();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult getUserWeaponsById(int id) {
            var user = _dbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            if (user == null) {
                //returns 404
                return NotFound(new { Message = "User not found or has no items!" });
            }
            //gets a list of characterid's using the user id as reference
            IEnumerable<int> weapons = _dbContext.UserWeapons.Where(x => x.UserId == id)
                .Select(w => w.WeaponId).ToList();
            return Ok(weapons);
        }
    }
}
