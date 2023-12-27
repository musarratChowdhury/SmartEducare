﻿namespace SmartEducation.Models.Entities
{
	public class Tutor
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Mobile { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
    }
}
