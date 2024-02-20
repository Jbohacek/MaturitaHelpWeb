using System.ComponentModel;
using System.Runtime.CompilerServices;

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
                name: "Main",
                pattern: "{area=Programovani}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();




        }
    }

    public class Person
    {
        ////Nejlepsi mo�n� z�pis
        //public int Age { get; set; }


        ////Del�� z�pis nejlep��ho z�pisu
        //private int age;

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        age = value;
        //    }
        //}


        //// D��vej�� z�pis prom�n� (nepou��vat)
        //private int _age;

        //public void SetAge(int age)
        //{
        //    _age = age;
        //}

        //public int GetAge()
        //{
        //    return _age;
        //}
        






        public string Name { get; set; }
        
        //Metoda
        public void WhatsMyName()
        {
            Console.WriteLine("My name is " + Name);
        }

        //Construktor
        public Person(string name,int age)
        {
            Name = name;



        }
    }
}