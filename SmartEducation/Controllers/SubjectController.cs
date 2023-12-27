using Microsoft.AspNetCore.Mvc;
using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using SmartEducation.Services;

namespace SmartEducation.Controllers
{
	public class SubjectController :  Controller
	{
		private readonly ISubjectService _subjectService;

		public SubjectController(ISubjectService subjectService)
		{
			_subjectService = subjectService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(SubjectDto subjectDto)
		{
			var newSubject = new Subject { Name = subjectDto.Name };
			_subjectService.AddSubject(newSubject);

			return RedirectToAction("Index");
		}
	}
}
