using Class2.Services;
using Class2.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<App>();
            serviceCollection.AddSingleton<IUserInfoService, UserInfoService>();

            var serviceProvider =  serviceCollection.BuildServiceProvider();

            var app = serviceProvider.GetRequiredService<App>();
            app.Main();
        }
    }
}