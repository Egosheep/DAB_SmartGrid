using System;

namespace SmartGrid_ServerApp
{
    public class SmartGridInfo
    {
        public int Id { get; set; }
        public double KiloWattPrice { get; set; }
        public double TokenPrice { get; set; }
        public double NationalGridPrice { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}