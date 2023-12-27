using Microsoft.AspNetCore.Mvc;
using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using SmartEducation.Services;

namespace SmartEducation.Controllers
{
    public class DayController :  Controller
    {
        private readonly IDayService _dayService;

        public DayController(IDayService dayService)
        {
            _dayService = dayService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DayDto dayDto)
        {
            var newDay = new Day
            {
                Date = dayDto.Date,
                StudyTopics = dayDto.StudyTopics,
                TutorId = dayDto.TutorId,
            };
            _dayService.AddDay(newDay);
            return  RedirectToAction("Index");
        }
    }
}