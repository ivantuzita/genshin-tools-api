using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GenshinToolsAPI.Models {
    [Keyless]
    public class UserCharacters {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CharacterId { get; set; }
    }
}
