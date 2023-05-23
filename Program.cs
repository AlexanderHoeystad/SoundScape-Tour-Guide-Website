using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Catalogs;

//namespace Pizza_StoreV8
//{


//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateHostBuilder(args).Build().Run();
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args) =>
//                    Host.CreateDefaultBuilder(args)
//                        .ConfigureWebHostDefaults(webBuilder =>
//                        {
//                            webBuilder.UseStartup<Startup>();
//                        });
//    }
//}
var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddRazorPages();

//builder.Services.AddSingleton<ISoundRepository, SoundAdmin>();
builder.Services.AddTransient<ISoundRepository, SoundAdmin>();

builder.Services.AddAuthentication().AddCookie("MyCookieAuth", options =>
{
    options.Cookie.Name = "MyCookieAuth";
    options.LoginPath = "/Account/Login";

});

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//.AddCookie(option => {
//    option.LoginPath = "/Account/login";
//    option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
//    option.Cookie.Name = "MyCookieAuth";

//});


var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapRazorPages();

    app.Run();
