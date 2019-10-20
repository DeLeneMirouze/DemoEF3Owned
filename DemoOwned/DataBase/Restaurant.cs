using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoOwned.DataBase
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }
    }
}
