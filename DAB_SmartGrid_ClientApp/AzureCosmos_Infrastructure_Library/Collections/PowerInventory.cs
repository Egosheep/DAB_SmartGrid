using System;

namespace AzureCosmos_Infrastructure_Library.Collections
{
    public class PowerInventory : IHasIdentifier
    {
        public string Id { get; set; }
        public string SellerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string PowerAmount { get; set; }
    }
}