using Class2.Interface;
using Class2.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<Application>();
            serviceCollection.AddSingleton<IUserInfo, UserInfoService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var app = serviceProvider.GetRequiredService<Application>();

            app.Main();

        }
    }
}