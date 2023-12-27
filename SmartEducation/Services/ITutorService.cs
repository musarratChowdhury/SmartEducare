using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
    public interface ITutorService
    {
        void AddTutor(Tutor tutor);
        void DeleteTutor(int id);
        IEnumerable<Tutor> GetAllTutors();
        Tutor GetTutorById(int id);
        IEnumerable<Tutor> GetTutorsByCondition(Expression<Func<Tutor, bool>> condition);
        void UpdateTutor(Tutor tutor);
    }
}