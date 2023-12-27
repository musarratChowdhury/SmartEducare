using SmartEducation.DataAccess.Repositories;
using SmartEducation.Models.Entities;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
    public class TutorService : ITutorService
    {
        private readonly IGenericRepository<Tutor> _tutorRepository;

        public TutorService(IGenericRepository<Tutor> tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }

        public IEnumerable<Tutor> GetAllTutors()
        {
            return _tutorRepository.GetAll();
        }

        public Tutor GetTutorById(int id)
        {
            return _tutorRepository.GetById(id);
        }

        public IEnumerable<Tutor> GetTutorsByCondition(Expression<Func<Tutor, bool>> condition)
        {
            return _tutorRepository.GetByCondition(condition);
        }

        public void AddTutor(Tutor tutor)
        {
            _tutorRepository.Add(tutor);
            _tutorRepository.Save();
        }

        public void UpdateTutor(Tutor tutor)
        {
            _tutorRepository.Update(tutor);
            _tutorRepository.Save();
        }

        public void DeleteTutor(int id)
        {
            _tutorRepository.Delete(id);
            _tutorRepository.Save();
        }
    }

}