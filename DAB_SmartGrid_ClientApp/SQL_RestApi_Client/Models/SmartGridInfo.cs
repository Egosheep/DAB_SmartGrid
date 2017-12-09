using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQL_RestApi_Client.Models
{
    public class SmartGridInfo
    {
        public int Id { get; set; }
        public double kiloWattPrice { get; set; }
        public double tokenPrice { get; set; }
        public double nationalGridPrice { get; set; }
        public DateTime timeStamp { get; set; }
    }
}