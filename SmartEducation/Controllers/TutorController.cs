using Microsoft.AspNetCore.Mvc;
using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using SmartEducation.Services;

namespace SmartEducation.Controllers
{
    public class TutorController :  Controller
    {
        private readonly ITutorService _tutorService;

        public TutorController(ITutorService tutorService)
        {
            _tutorService = tutorService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TutorDto tutorDto)
        {
            var newTutor = new Tutor
            {
                Name = tutorDto.Name,
                StartDate = tutorDto.StartDate
            };
            _tutorService.AddTutor(newTutor);
            return  RedirectToAction("Index");
        }
    }
}