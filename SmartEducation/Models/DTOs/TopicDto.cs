using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SmartEducation.Models.Entities;
using SmartEducation.Models.Enums;

namespace SmartEducation.Models.DTOs
{
	public class TopicDto
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;
		public DateTime EntryDate { get; set; }
		public int RevisionCount { get; set; }
		public DateTime LastRevised { get; set; }
		public string Chapter { get; set; } = string.Empty;
		public int Page { get; set; }
		public MemoryStatus Status { get; set; }
		public DifficultyLevel Difficulty { get; set; }

		[DisplayName("Subject")]
		public int SubjectId { get; set; }
		[DisplayName("Book")]
		public int BookId { get; set; }
	}
}
