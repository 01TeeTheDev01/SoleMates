using Microsoft.EntityFrameworkCore;

using SoleMatesWA.Data;
using SoleMatesWA.Repository;

namespace SoleMatesWA;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<SoleMatesWAContext>(options =>
        {
            string? connection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("No connection string found.");

            options
            .UseNpgsql(connection)
            .EnableThreadSafetyChecks()
            .EnableDetailedErrors();
        });

        // Add the repository
        builder.Services.AddScoped<IEventRepository, EventRepository>();
        builder.Services.AddScoped<ICommentRepository, CommentRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        // Serve static files (e.g., from wwwroot)
        app.UseStaticFiles();

        // Enable HTTPS redirection
        app.UseHttpsRedirection();

        // Set up routing
        app.UseRouting();

        // Enable authorization
        app.UseAuthorization();

        // Map controller routes
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        // Run the app
        app.Run();
    }
}