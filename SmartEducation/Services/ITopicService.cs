using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
	public interface ITopicService
	{
		void AddTopic(TopicDto topicDto);
		void DeleteTopic(int id);
		IEnumerable<Topic> GetAllTopics();
		Topic GetTopicById(int id);
		IEnumerable<Topic> GetTopicsByCondition(Expression<Func<Topic, bool>> condition);
		void UpdateTopic(Topic topic);
	}
}