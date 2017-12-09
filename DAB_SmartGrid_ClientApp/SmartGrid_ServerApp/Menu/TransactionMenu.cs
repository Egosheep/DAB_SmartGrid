using System;
using System.Threading;

namespace SmartGrid_ServerApp
{
    public class TransactionMenu : IMenu
    {
        private Prosumer _prosumer;
        private ITransactionManager _transactionManager;
        public TransactionMenu(Prosumer prosumer)
        {
            _prosumer = prosumer;
            _transactionManager = new TransactionManager();
        }
        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to transactionMenu. From here you can (S)ell, (B)uy, view (P)ending or (C)ompleted transactions");
                var key = Console.ReadLine().ToLower();
                switch (key)
                {
                    case "s":
                        Console.Clear();
                        Console.WriteLine("How many kWh do you want to sell? ");
                        var kwhToSell = Console.ReadLine();
                        if (!ContainsOnlyDigits(kwhToSell))
                        {
                            Console.WriteLine("U entered invalid number of kWh to sell");
                            Thread.Sleep(1000);
                            break;
                        }
                        break;
                    case "b":
                        break;
                    case "p":
                        break;
                    case "c":
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
    }
}