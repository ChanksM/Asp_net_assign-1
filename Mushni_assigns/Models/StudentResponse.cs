using System.ComponentModel.DataAnnotations;

namespace Mushni_assigns.Models;

public class StudentResponse
{
    [Required(ErrorMessage = "Please enter your name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter your email address")]
    [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter your phone number")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Please choose faculty")]
    public string? Faculty { get; set; }
}