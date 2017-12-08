using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL_RestApi_Client.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}