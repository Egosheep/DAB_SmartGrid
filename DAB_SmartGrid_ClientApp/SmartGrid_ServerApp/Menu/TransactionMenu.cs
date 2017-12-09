using System;

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
            }
        }
    }
}