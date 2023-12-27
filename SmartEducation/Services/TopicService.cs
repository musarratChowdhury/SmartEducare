using SmartEducation.DataAccess.Repositories;
using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace SmartEducation.Services
{

	public class TopicService : ITopicService
	{
		private readonly IGenericRepository<Topic> _topicRepository;
		private readonly IGenericRepository<Book> _bookRepository;
		private readonly IGenericRepository<Subject> _subjectRepository;

		public TopicService(IGenericRepository<Topic> topicRepository, IGenericRepository<Book> bookRepository, IGenericRepository<Subject> subjectRepository)
		{
			_topicRepository = topicRepository;
			_bookRepository = bookRepository;
			_subjectRepository = subjectRepository;
		}

		public IEnumerable<Topic> GetAllTopics()
		{
			var allTopics   =  _topicRepository.GetAll();
			foreach (var topic in allTopics)
			{
				if(topic.BookId != -1 || topic.BookId !=0)
				{
					topic.Book = _bookRepository.GetById(topic.BookId);
				}
				if(topic.SubjectId != -1 || topic.SubjectId != 0)
				{
					topic.Subject = _subjectRepository.GetById(topic.SubjectId);
				}
			}

			return allTopics;
		}

		public Topic GetTopicById(int id)
		{
			return _topicRepository.GetById(id);
		}

		public IEnumerable<Topic> GetTopicsByCondition(Expression<Func<Topic, bool>> condition)
		{
			return _topicRepository.GetByCondition(condition);
		}

		public void AddTopic(TopicDto topicDto)
		{
			var topic = new Topic()
			{
				Title = topicDto.Title,
				Description = topicDto.Description,
				Image = topicDto.Image,
				EntryDate = DateTime.Now,
				RevisionCount = topicDto.RevisionCount,
				LastRevised = DateTime.Now,
				Status = topicDto.Status,
				Chapter = topicDto.Chapter,
				Page = topicDto.Page,
				Difficulty = topicDto.Difficulty,
				BookId = topicDto.BookId,
				SubjectId = topicDto.SubjectId,
			};
			_topicRepository.Add(topic);
			_topicRepository.Save();
		}

		public void UpdateTopic(Topic topic)
		{
			_topicRepository.Update(topic);
			_topicRepository.Save();
		}

		public void DeleteTopic(int id)
		{
			_topicRepository.Delete(id);
			_topicRepository.Save();
		}
	}

}
