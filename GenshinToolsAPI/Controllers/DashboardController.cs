using GenshinToolsAPI.Data;
using Microsoft.AspNetCore.Mvc;
using GenshinToolsAPI.Models;

namespace GenshinToolsAPI.Controllers {
    [Route("api/dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase {

        private readonly GenshinContext _dbContext;

        public DashboardController(GenshinContext dbContext) {
            _dbContext = dbContext;
        }

        //gets all characters
        [HttpGet("characters")]
        public ICollection<Character> getCharacters() {
            return _dbContext.Characters.ToList();
        }

        //gets all weapons
        [HttpGet("weapons")]
        public ICollection<Weapon> getWeapons() {
            return _dbContext.Weapons.ToList();
        }

        [HttpGet("characters/{id}")]
        public IActionResult getUserCharactersById(int id) {
            var user = _dbContext.Users.FirstOrDefault(user => user.Id == id);
            if (user == null) {
                //returns 404
                return NotFound(new { Message = "User not found." });
            }
            IEnumerable<int> userCharIds = _dbContext.UserCharacters.Where(x => x.UserId == id)
                .Select(c => c.CharacterId).ToList();

            return Ok(userCharactersFiltered(userCharIds));
        }

        [HttpGet("weapons/{id}")]
        public IActionResult getUserWeaponsById(int id) {
            var user = _dbContext.Users.FirstOrDefault(user => user.Id == id);
            if (user == null) {
                //returns 404
                return NotFound(new { Message = "User not found." });
            }
            IEnumerable<int> userWeaponsIds = _dbContext.UserWeapons.Where(x => x.UserId == id)
                .Select(w => w.WeaponId).ToList();
            //returns 200 with the list of weapons that can be upgraded today
            return Ok(userWeaponsFiltered(userWeaponsIds));
        }

        private List<Character> userCharactersFiltered(IEnumerable<int> userCharacters) {
            IEnumerable<int> filteredChars = _dbContext.TalentWeekDays.Where(x => x.WeekDayId == dayOfWeek())
                .Select(c => c.CharacterId).ToList();
            IEnumerable<int> join = userCharacters.Intersect(filteredChars);
            List<Character> chars = new List<Character>();

            foreach (var characterId in join) {
                chars.Add(_dbContext.Characters.FirstOrDefault(x => x.Id == characterId));
            }
            return chars;
        }

        private List<Weapon> userWeaponsFiltered(IEnumerable<int> userWeapons) {
            IEnumerable<int> filteredWeapons = _dbContext.WeaponWeekDays.Where(x => x.WeekDayId == dayOfWeek())
                .Select(c => c.WeaponId).ToList();
            IEnumerable<int> join = userWeapons.Intersect(filteredWeapons);
            List<Weapon> weapons = new List<Weapon>();

            foreach (var weaponId in join) {
                weapons.Add(_dbContext.Weapons.FirstOrDefault(x => x.Id == weaponId));
            }
            return weapons;
        }

        private int dayOfWeek() {
            return ((int)DateTime.Now.DayOfWeek + 6) % 7;
        }

    }
}
