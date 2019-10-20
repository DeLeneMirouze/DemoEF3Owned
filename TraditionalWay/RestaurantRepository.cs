using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TraditionalWay.DataBase;

namespace TraditionalWay
{
    public sealed class RestaurantRepository
    {
        readonly MyContext _MyContext;

        public RestaurantRepository(IConfigurationRoot configuration)
        {
            string cnx = configuration.GetConnectionString("tradi");
            var builder = new DbContextOptionsBuilder<MyContext>();
            builder.UseSqlServer(cnx);

            _MyContext = new MyContext(builder.Options);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _MyContext.Set<Restaurant>()
                .Add(restaurant);

            _MyContext.SaveChanges();

            return restaurant;
        }

        public Restaurant Get(int id)
        {
            var restaurant = _MyContext.Set<Restaurant>()
                .Find(id);

            return restaurant;
        }

        public void Update(Restaurant restaurant)
        {
            var entity = _MyContext.Set<Restaurant>().Find(restaurant.Id);
            entity.Address.Number = restaurant.Address.Number;

            _MyContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _MyContext.Set<Restaurant>()
                .Find(id);
            _MyContext.Remove(entity);

            var entityAdd = _MyContext.Set<Address>()
                .Find(entity.IdAddress);
            _MyContext.Remove(entityAdd);

            _MyContext.SaveChanges();
        }
    }
}
