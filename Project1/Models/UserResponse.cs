using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please choose a subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please type a short message to Mission Connections")]
        public string Message { get; set; }
    }
}