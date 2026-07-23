using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{

    public class UserInfo
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter your name.")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "Please, enter your phone number.")]
        public string? Phone { get; set; }
        
        [Required(ErrorMessage = "Please, enter your e-mail address.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "Please, enter your status.")]
        public bool? AttendanceStatus { get; set; }
    }

}