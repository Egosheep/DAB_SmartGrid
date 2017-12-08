using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL_RestApi_Client.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Prosumer
    {
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