using System;
using System.Net.Http;
using System.Threading;

namespace SmartGrid_ServerApp
{
    public class MainMenu : IMenu
    {
        private readonly ILoginManager _loginManager;
        private IMenu _transactionMenu;
        private readonly IConsolePrinter _consolePrinter;

        public MainMenu(ILoginManager loginManager)
        {
            _loginManager = loginManager;
            _consolePrinter = new ConsolePrinter();
        }
        public void DisplayMenu()
        {
            while(true)
            {
                _consolePrinter.PrinterCenteredHeader("Welcome to SmartPowerGrid.");
                Console.Write("Please Enter Your ID: ");
                var id = Console.ReadLine();
                var prosumer = _loginManager.ValidateLogin(int.Parse(id));
                if (prosumer != null)
                {
                    _transactionMenu = new TransactionMenu(prosumer.Result);
                    Console.WriteLine("Welcome " + prosumer.Result.FirstName + prosumer.Result.LastName);
                    Console.WriteLine("Directing to Transaction Menu");
                    _transactionMenu.DisplayMenu();
                }
                else
                {
                    Console.WriteLine("No Prosumer was found with that ID");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}