using SmartEducation.DataAccess.Repositories;
using SmartEducation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace SmartEducation.Services
{

	public class BookService : IBookService
	{
		private readonly IGenericRepository<Book> _bookRepository;

		public BookService(IGenericRepository<Book> bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public IEnumerable<Book> GetAllBooks()
		{
			return _bookRepository.GetAll();
		}

		public Book GetBookById(int id)
		{
			return _bookRepository.GetById(id);
		}

		public IEnumerable<Book> GetBooksByCondition(Expression<Func<Book, bool>> condition)
		{
			return _bookRepository.GetByCondition(condition);
		}

		public void AddBook(Book book)
		{
			_bookRepository.Add(book);
			_bookRepository.Save();
		}

		public void UpdateBook(Book book)
		{
			_bookRepository.Update(book);
			_bookRepository.Save();
		}

		public void DeleteBook(int id)
		{
			_bookRepository.Delete(id);
			_bookRepository.Save();
		}
	}

}
