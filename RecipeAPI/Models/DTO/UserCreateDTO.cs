﻿using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Models.DTO
{
    public class UserCreateDTO
    {
        [Required(ErrorMessage = "Username is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the username is 50 characters.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the email is 50 characters.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is a required field")]
        [MaxLength(50, ErrorMessage = "Maximum length for the password is 50 characters.")]
        public string Password { get; set; }
    }
}
