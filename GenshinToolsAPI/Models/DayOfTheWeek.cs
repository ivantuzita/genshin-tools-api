
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GenshinToolsAPI.Models {
    [Keyless]
    public class DayOfTheWeek {

        [Required]
        public int CharacterId { get; set; }
        [Required]
        public int WeekDayId { get; set; }

    }
}
