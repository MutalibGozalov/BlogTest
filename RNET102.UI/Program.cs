using Microsoft.EntityFrameworkCore;
using RNET102.UI.Data;
using RNET102.UI.Models;

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

		using(var scope = app.Services.CreateScope())
		{
			var services = scope.ServiceProvider;
			Seed.Initialize(services);
		}

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

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapControllerRoute(
			  name: "areas",
			  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
			);

			endpoints.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");
		});

		app.Run();
	}
}