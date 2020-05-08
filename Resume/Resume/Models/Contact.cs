using System.ComponentModel.DataAnnotations;

namespace Resume.Models
{
  public class Contact
  {
    [Required(ErrorMessage = "This field is required. What's your email address?")]
    [EmailAddress(ErrorMessage = "This doesn't look like an email address. What's your real email address?")]
    public string Email { get; set; }

    [Required(ErrorMessage = "This field is required. Resume your message usign a few keywords.")]
    [MaxLength(127, ErrorMessage = "Summarize your message using fewer words. Keep the rest for the next field.")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "This field is required. Let me know your thoughts.")]
    [MaxLength(2047, ErrorMessage = "I really like good stories but your message is too long.")]
    public string Message { get; set; }
  }
}
