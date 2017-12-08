using System.ComponentModel.DataAnnotations;

namespace SQL_Infrastructure_Library.Entities
{
    public class Prosumer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string ProsumerType { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public virtual Address Address { get; set; }
    }
}