﻿using System;

namespace SmartGrid_ServerApp
{
    using Newtonsoft.Json;

    public class CompletedTransaction
    {
        

        public string Id { get; set; }
        public string SellerId { get; set; }
        public string BuyerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string PowerAmount { get; set; }
        public string TransactionPrice { get; set; }

        public override string ToString()
        {
            return "Seller ID: " + SellerId + ".\nBuyer ID: " + BuyerId + ".\nTransaction Time: " +TransactionTime.ToShortDateString()+ " " + TransactionTime.ToShortTimeString() + ".\nPower transferred: " + PowerAmount + ".\nTransaction price: " + TransactionPrice+".";
        }
    }
}