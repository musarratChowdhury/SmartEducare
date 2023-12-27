using SmartEducation.DataAccess.Repositories;
using SmartEducation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
	public class SubjectService : ISubjectService
	{
		private readonly IGenericRepository<Subject> _subjectRepository;

		public SubjectService(IGenericRepository<Subject> subjectRepository)
		{
			_subjectRepository = subjectRepository;
		}

		public IEnumerable<Subject> GetAllSubjects()
		{
			return _subjectRepository.GetAll();
		}

		public Subject GetSubjectById(int id)
		{
			return _subjectRepository.GetById(id);
		}

		public IEnumerable<Subject> GetSubjectsByCondition(Expression<Func<Subject, bool>> condition)
		{
			return _subjectRepository.GetByCondition(condition);
		}

		public void AddSubject(Subject subject)
		{
			_subjectRepository.Add(subject);
			_subjectRepository.Save();
		}

		public void UpdateSubject(Subject subject)
		{
			_subjectRepository.Update(subject);
			_subjectRepository.Save();
		}

		public void DeleteSubject(int id)
		{
			_subjectRepository.Delete(id);
			_subjectRepository.Save();
		}
	}

}
