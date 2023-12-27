using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartEducation.Models.DTOs;
using SmartEducation.Services;

namespace SmartEducation.Controllers
{
	public class TopicController :  Controller
	{
		public readonly ITopicService _topicService;
		public  readonly IBookService _bookService;
		public readonly ISubjectService _subjectService;

        public TopicController(ITopicService topicService, IBookService bookService, ISubjectService subjectService)
        {
            _topicService = topicService;
			_bookService = bookService;
			_subjectService = subjectService;
        }

		public ActionResult Index() { 
			var allTopics  = _topicService.GetAllTopics().ToList();
			return View(allTopics);
		}

		public IActionResult Create()
		{
			var books = _bookService.GetAllBooks();
			var subjects = _subjectService.GetAllSubjects();
			ViewBag.Books = new SelectList(books, "Id", "Title");
			ViewBag.Subjects = new SelectList(subjects, "Id", "Name");

			return View();
		}


		[HttpPost]
		public IActionResult Create(TopicDto topicDto)
		{
			_topicService.AddTopic(topicDto);
			return RedirectToAction("Index");
		}
	}
}
