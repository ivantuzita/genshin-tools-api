using GenshinToolsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GenshinToolsAPI.Data {
    public class GenshinContext: DbContext {

        public GenshinContext(DbContextOptions<GenshinContext> options)
            : base(options) {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Weapon> Weapons { get; set; } = null!;
        public DbSet<TalentDayOfTheWeek> TalentWeekDays { get; set; } = null!;
        public DbSet<WeaponDayOfTheWeek> WeaponWeekDays { get; set; } = null!;
        public DbSet<UserCharacters> UserCharacters { get; set; } = null!;
        public DbSet<UserWeapons> UserWeapons { get; set; } = null!;
    }
}
