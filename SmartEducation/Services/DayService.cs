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

        public DayService(IGenericRepository<Day> dayRepository)
        {
            _dayRepository = dayRepository;
        }

        public IEnumerable<Day> GetAllDays()
        {
            return _dayRepository.GetAll();
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