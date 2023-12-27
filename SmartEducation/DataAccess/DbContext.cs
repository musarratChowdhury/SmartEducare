using Microsoft.EntityFrameworkCore;
using SmartEducation.Models.Entities;

namespace SmartEducation.DataAccess
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

	
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Tutor> Tutors { get; set; }
		public DbSet<Day> Days { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Book>()
				.HasMany(b => b.TopicList)
				.WithOne(t => t.Book)
				.HasForeignKey(t => t.BookId);

			modelBuilder.Entity<Subject>()
				.HasMany(s => s.TopicList)
				.WithOne(t => t.Subject)
				.HasForeignKey(t => t.SubjectId);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite("Data Source=.\\SqlLiteDb.db"); // Replace with your actual connection string
			}
		}
	}
}
