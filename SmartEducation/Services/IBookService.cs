using SmartEducation.Models.Entities;
using System.Linq.Expressions;

namespace SmartEducation.Services
{
	public interface IBookService
	{
		void AddBook(Book book);
		void DeleteBook(int id);
		IEnumerable<Book> GetAllBooks();
		Book GetBookById(int id);
		IEnumerable<Book> GetBooksByCondition(Expression<Func<Book, bool>> condition);
		void UpdateBook(Book book);
	}
}