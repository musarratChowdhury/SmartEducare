using Microsoft.AspNetCore.Mvc;
using SmartEducation.Models.DTOs;
using SmartEducation.Models.Entities;
using SmartEducation.Services;

namespace SmartEducation.Controllers
{
	public class BookController :  Controller
	{
		private readonly IBookService _bookService;

		public BookController(IBookService bookService)
		{
			_bookService = bookService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(BookDto bookDto)
		{
			var newBook = new Book { Title = bookDto.Title };
			_bookService.AddBook(newBook);
			return  RedirectToAction("Index");
		}
	}
}
