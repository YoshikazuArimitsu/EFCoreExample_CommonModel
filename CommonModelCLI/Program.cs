using CommonModelLib.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CommonModelCLI
{
    internal class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<CommonDbContext>(options =>
                    {
                        options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=SampleDB;Trusted_Connection=True;");
                    });
                    services.AddSingleton<MyService>();
                });

        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var myService = host.Services.GetRequiredService<MyService>();
            myService.DoSomething();
        }
    }

    public class MyService {
        private readonly CommonDbContext _CommonDbContext;
        public MyService(CommonDbContext dbContext)
        {
            _CommonDbContext = dbContext;
        }

        public void DoSomething()
        {
        }
    }
}
