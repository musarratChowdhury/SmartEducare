using System.ComponentModel.DataAnnotations;

namespace SmartEducation.Models.DTOs;

public class TutorDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "Mobile No is required")]
    public string Mobile { get; set; } = string.Empty;

    [Required(ErrorMessage = "StartDate is required")]
    public DateTime StartDate { get; set; }
}