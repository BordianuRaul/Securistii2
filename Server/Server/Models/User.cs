﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server.Models
{
    public class User
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
        [Required] public string Username { get; set; } = string.Empty;
        [Required] public string ProfilePicturePath { get; set; } = string.Empty;
    }
}
