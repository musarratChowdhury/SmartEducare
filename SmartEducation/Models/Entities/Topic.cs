using SmartEducation.Models.Enums;

namespace SmartEducation.Models.Entities
{
	public class Topic
	{
        public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;
        public DateTime EntryDate { get; set; }
		public int RevisionCount { get; set; }
		public DateTime LastRevised { get; set; }
		public string Chapter { get; set; } = string.Empty;
		public int Page { get;set; }
        public MemoryStatus Status { get; set; }
        public DifficultyLevel Difficulty { get; set; }

		public int SubjectId { get; set; } = -1;
		public Subject? Subject { get; set; }
		public int BookId { get; set; } = -1;
		public Book? Book { get; set; }	
    }
}
