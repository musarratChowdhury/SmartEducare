namespace SmartEducation.Models.Entities
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;

		public List<Topic>? TopicList { get; set; }
	}
}
