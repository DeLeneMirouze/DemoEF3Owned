using Bogus;
using DemoOwned.DataBase;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DemoOwned
{
    class Program
    {
        static Program()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _Configuration = builder.Build();
        }

        readonly static IConfigurationRoot _Configuration;

        static void Main()
        {
            var repository = new RestaurantRepository(_Configuration);

            var fakeAddress = new Faker<Address>()
                .RuleFor(bp => bp.Zip, f => f.Address.ZipCode())
                .RuleFor(bp => bp.Street, f => f.Address.StreetName())
                .RuleFor(bp => bp.Town, f => f.Address.City());

            var fakeResto = new Faker<Restaurant>()
                .RuleFor(bp => bp.Name, f => f.Company.CompanyName())
                .RuleFor(bp => bp.Address, () => fakeAddress);

            Restaurant restaurant = fakeResto.Generate();


            Restaurant created = repository.Add(restaurant);
            var newRestaurant = repository.Get(created.Id);

            newRestaurant.Address.Number = "15";
            repository.Update(newRestaurant);

            repository.Delete(newRestaurant.Id);

        }
    }
}
