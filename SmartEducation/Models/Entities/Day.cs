namespace SmartEducation.Models.Entities;

public class Day
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string StudyTopics { get; set; } = string.Empty;
    public Tutor? Tutor { get; set; }
    public int TutorId { get; set; } = -1;
}