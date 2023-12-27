using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
    public interface IDayService
    {
        void AddDay(Day day);
        void DeleteDay(int id);
        IEnumerable<Day> GetAllDays();
        Day GetDayById(int id);
        IEnumerable<Day> GetDaysByCondition(Expression<Func<Day, bool>> condition);
        void UpdateDay(Day day);
    }
}