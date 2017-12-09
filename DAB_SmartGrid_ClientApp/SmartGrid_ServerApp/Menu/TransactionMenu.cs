using System;

namespace SmartGrid_ServerApp
{
    public class TransactionMenu : IMenu
    {
        private Prosumer prosumer;
        private ITransactionManager transactionManager;
        public TransactionMenu(Prosumer _prosumer)
        {
            prosumer = _prosumer;
            transactionManager = new TransactionManager();
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