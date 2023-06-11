using GenshinToolsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GenshinToolsAPI.Data {
    public class GenshinContext: DbContext {

        public GenshinContext(DbContextOptions<GenshinContext> options)
            : base(options) {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<DayOfTheWeek> DaysOfWeek { get; set; } = null!;
    }
}
