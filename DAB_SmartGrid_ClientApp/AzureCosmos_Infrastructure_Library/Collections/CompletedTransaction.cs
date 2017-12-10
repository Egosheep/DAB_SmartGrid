using System;

namespace AzureCosmos_Infrastructure_Library.Collections
{
    using Newtonsoft.Json;

    public class CompletedTransaction : IHasIdentifier
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string SellerId { get; set; }
        public string BuyerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string PowerAmount { get; set; }
        public string TransactionPrice { get; set; }
    }
}