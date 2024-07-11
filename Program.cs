using FilmTicketShop.Data;
using FilmTicketShop.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//Service configuration
builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IProducerService, ProducerService>();
builder.Services.AddScoped<ICinemasService, CinemaService>();
builder.Services.AddScoped<IMoviesService, MoviesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
void ConfigureServies(IServiceCollection services)
{
	//DbContext configuration
	services.AddDbContext<AppDbContext>();

	
	services.AddControllersWithViews();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

AppDbInitializer.Seed(app);

app.Run();
