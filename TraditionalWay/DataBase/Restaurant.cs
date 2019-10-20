using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TraditionalWay.DataBase
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [ForeignKey("Address")]
        public int IdAddress { get; set; }

        public Address Address { get; set; }
    }
}
