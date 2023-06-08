using Microsoft.EntityFrameworkCore;
using RNET102.UI.Data;

internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddControllersWithViews();

		builder.Services.AddDbContext<RNET102DbContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCnnString") ?? throw new InvalidOperationException("Connection string not found.")));
		
		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		app.Run();
	}
}