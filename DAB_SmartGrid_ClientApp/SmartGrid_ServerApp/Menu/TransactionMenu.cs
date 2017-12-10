using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace SmartGrid_ServerApp
{
    public class TransactionMenu : IMenu
    {
        private readonly Prosumer _prosumer;
        private ITransactionManager _transactionManager;
        private readonly IConsolePrinter _consolePrinter;

        public TransactionMenu(Prosumer prosumer)
        {
            _prosumer = prosumer;
            _transactionManager = new TransactionManager();
            _consolePrinter = new ConsolePrinter();
        }
        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                _consolePrinter.PrinterCenteredHeader("Welcome to transactionMenu.");
                Console.WriteLine("From here you can (S)ell, (B)uy, view (P)ending or (C)ompleted transactions");
                var key = Console.ReadLine().ToLower();
                switch (key)
                {
                    case "s":
                        Console.Clear();
                        Console.WriteLine("How many kWh do you want to sell? ");
                        var kwhToSell = Console.ReadLine();
                        if (!ContainsOnlyDigits(kwhToSell))
                        {
                            Console.WriteLine("You entered an invalid number of kWh to sell");
                            Thread.Sleep(1000);
                            break;
                        }
                        SellPower(_prosumer, kwhToSell);
                        Console.WriteLine("Power placed in inventory to sell");
                        Thread.Sleep(1000);
                        break;
                    case "b":
                        Console.Clear();
                        Console.WriteLine("How many kWh do you want to buy? ");
                        var kwhToBuy = Console.ReadLine();
                        if (!ContainsOnlyDigits(kwhToBuy))
                        {
                            Console.WriteLine("You entered an invalid number");
                            Thread.Sleep(1000);
                            break;
                        }
                        BuyPower(_prosumer, kwhToBuy);
                        Console.WriteLine("Transaction has been created");
                        Thread.Sleep(1000);
                        break;
                    case "p":
                        ShowPendingTransactions(_prosumer);
                        break;
                    case "c":
                        ShowTransactionHistory(_prosumer);
                        break;
                }
            }
        }
        private bool ContainsOnlyDigits(string str)
        {
            foreach (var c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void SellPower(Prosumer prosumer, string powerToSell)
        {
            _transactionManager.CreatePowerInventoryItem(prosumer, powerToSell);
        }

        private void BuyPower(Prosumer prosumer, string powerToBuy)
        {
            _transactionManager.CreateTransaction(prosumer, powerToBuy);
        }

        private void ShowTransactionHistory(Prosumer prosumer)
        {
            var getPath = AzureWebApiCaller.Client.BaseAddress + "/CompletedTransactions?queryOption="+prosumer.Id;
            var receive = AzureWebApiCaller.Client.GetAsync(getPath).Result.Content
                .ReadAsAsync<List<CompletedTransaction>>().Result;
            Console.Clear();
            foreach (CompletedTransaction completedTransaction in receive)
            {
                Console.WriteLine(completedTransaction.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private void ShowPendingTransactions(Prosumer prosumer)
        {
            var getPath = AzureWebApiCaller.Client.BaseAddress + "/PendingTransactions?queryOptions=" + prosumer.Id;
            var receive = AzureWebApiCaller.Client.GetAsync(getPath).Result.Content.ReadAsAsync<List<PendingTransaction>>().Result;
            Console.Clear();
            foreach (var pendingTransaction in receive)
            {
                Console.WriteLine(pendingTransaction.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}