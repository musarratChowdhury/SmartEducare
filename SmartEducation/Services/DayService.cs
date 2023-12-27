using SmartEducation.DataAccess.Repositories;
using SmartEducation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SmartEducation.Models.DTOs;

namespace SmartEducation.Services
{
    public class DayService : IDayService
    {
        private readonly IGenericRepository<Day> _dayRepository;
        private readonly IGenericRepository<Tutor> _tutorRepository;

        public DayService(IGenericRepository<Day> dayRepository, IGenericRepository<Tutor> tutorRepository)
        {
            _dayRepository = dayRepository;
            _tutorRepository = tutorRepository;
        }

        public IEnumerable<Day> GetAllDays()
        {
            var allDays = _dayRepository.GetAll();
            var enumerable = allDays.ToList();
            foreach (var day in enumerable)
            {
                day.Tutor = _tutorRepository.GetById(day.TutorId);
            }

            return enumerable;
        }

        public Day GetDayById(int id)
        {
            return _dayRepository.GetById(id);
        }

        public IEnumerable<Day> GetDaysByCondition(Expression<Func<Day, bool>> condition)
        {
            return _dayRepository.GetByCondition(condition);
        }

        public void AddDay(Day day)
        {
            _dayRepository.Add(day);
            _dayRepository.Save();
        }

        public void UpdateDay(Day day)
        {
            _dayRepository.Update(day);
            _dayRepository.Save();
        }

        public void DeleteDay(int id)
        {
            _dayRepository.Delete(id);
            _dayRepository.Save();
        }
    }

}