using System.ComponentModel.DataAnnotations;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Your dog must have a name!")]
        public string Name { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        public string Breed { get; set; }
        [AllowNull]
        public string Notes { get; set; }
        [AllowNull]
        public string ImageUrl { get; set; } 
    }
}
