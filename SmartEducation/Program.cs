using Microsoft.EntityFrameworkCore;
using SmartEducation.DataAccess;
using SmartEducation.DataAccess.Repositories;
using SmartEducation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ITopicService, TopicService>();
builder.Services.AddScoped<ISubjectService, SubjectService>();
builder.Services.AddScoped<IDayService, DayService>();
builder.Services.AddScoped<ITutorService, TutorService>();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlite(
		"Data Source=.\\SqlLiteDb.db",
		sqliteOptions =>
		{
			// Configure additional options here
			sqliteOptions.CommandTimeout(30);
		}
	)
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Topic}/{action=Index}/{id?}");

app.Run();
