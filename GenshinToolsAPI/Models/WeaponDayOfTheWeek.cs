using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GenshinToolsAPI.Models {
    [Keyless]
    public class WeaponDayOfTheWeek {
        [Required]
        public int WeaponId { get; set; }
        [Required]
        public int WeekDayId { get; set; }
    }
}
