using System.ComponentModel.DataAnnotations;

namespace SQL_Infrastructure_Library.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

    }
}