using System;

namespace AzureCosmos_Infrastructure_Library.Collections
{
    using Newtonsoft.Json;

    public class PowerInventory : IHasIdentifier
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string SellerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string PowerAmount { get; set; }
    }
}