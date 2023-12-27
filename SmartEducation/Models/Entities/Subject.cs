namespace SmartEducation.Models.Entities
{
	public class Subject
	{
        public int Id { get; set; }
		public string Name { get; set; } =   string.Empty;

		public List<Topic>? TopicList { get; set; }
    }
}
