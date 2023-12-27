using SmartEducation.Models.Entities;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
	public interface ISubjectService
	{
		void AddSubject(Subject subject);
		void DeleteSubject(int id);
		IEnumerable<Subject> GetAllSubjects();
		Subject GetSubjectById(int id);
		IEnumerable<Subject> GetSubjectsByCondition(Expression<Func<Subject, bool>> condition);
		void UpdateSubject(Subject subject);
	}
}