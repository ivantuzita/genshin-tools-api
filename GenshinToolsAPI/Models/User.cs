﻿using System.ComponentModel.DataAnnotations;

namespace GenshinToolsAPI.Models {
    public class User {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
