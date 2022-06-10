#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Dojo_Surey_With_Validations.Models;
public class Survey
{   
    [Required]
    [MinLength(2)]
    public string? Name { get; set; }
    [Required]
    public string? Location { get; set; }
    [Required]
    public string? Language { get; set; }
    [CommentValidation]
    public string? Comment { get; set; }
}


public class CommentValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((string)value) != null && ((string)value).Length < 20)
            return new ValidationResult("Comment must be at least 20 characters");
        return ValidationResult.Success;
    }
}