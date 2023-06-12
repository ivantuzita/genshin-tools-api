using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GenshinToolsAPI.Models {
    [Keyless]
    public class UserWeapons {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int WeaponId { get; set; }
    }
}

