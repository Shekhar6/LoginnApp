using System;
using System.ComponentModel.DataAnnotations;

namespace LoginApp.Model
{
    public class UserDetails
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="First name Required")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Last name Required")]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Mobile { get; set; }
    }
}
