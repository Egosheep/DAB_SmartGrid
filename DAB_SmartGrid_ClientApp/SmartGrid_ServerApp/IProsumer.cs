namespace SmartGrid_ServerApp
{
    public class Prosumer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string ProsumerType { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}