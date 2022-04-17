using DataAccess.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //try
            //{
            //    var host=CreateHostBuilder(args).Build();
            //    using (var scope=host.Services.CreateScope())
            //    {
            //        var serviceProvider = scope.ServiceProvider;
            //        var applicationDbContext = serviceProvider.GetRequiredService<DevelopersDbContext>();
            //        applicationDbContext.Database.Migrate();
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
