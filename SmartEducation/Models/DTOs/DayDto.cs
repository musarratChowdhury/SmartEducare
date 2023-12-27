using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartEducation.Models.DTOs;

public class DayDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Date is required")]
    public DateTime Date { get; set; }
    public string StudyTopics { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tutor is required")][DisplayName("Tutor")]
    public int TutorId { get; set; }
}