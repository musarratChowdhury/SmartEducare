using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using SmartEducation.Services;

namespace SmartEducation.Controllers
{
    public class DayController :  Controller
    {
        private readonly IDayService _dayService;
        private readonly ITutorService _tutorService;

        public DayController(IDayService dayService, ITutorService tutorService)
        {
            _dayService = dayService;
            _tutorService = tutorService;
        }

        public ActionResult Index()
        {
            var allDays  = _dayService.GetAllDays().ToList();
            return View(allDays);
        }

        public ActionResult Create()
        {
            var tutors = _tutorService.GetAllTutors();
            ViewBag.Tutors = new SelectList(tutors, "Id", "Name");
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