using System.ComponentModel;
using System.Runtime.CompilerServices;
using Maturita.Web.Managers;

namespace Maturita.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                name: "second",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();




        }
    }

    public class Log
    {
        public string Action { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }

    public class LogPage
    {
        public List<Log> Logs { get; set; }
        public DateTime EndTime { get; set; }

        public LogPage(List<Log> logs, DateTime endTime)
        {
            Logs = logs;
            EndTime = endTime;

            
        }
    }
}
