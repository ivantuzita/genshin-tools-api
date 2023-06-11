using System.ComponentModel.DataAnnotations;

namespace GenshinToolsAPI.Models
{
    public class Character
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PictureURL { get; set; }
    }
}