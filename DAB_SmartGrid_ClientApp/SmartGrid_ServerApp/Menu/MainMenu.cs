﻿using System;
using System.Threading;

namespace SmartGrid_ServerApp
{
    public class MainMenu : IMenu
    {
        private ILoginManager loginManager;
        private IMenu transactionMenu;
        public void DisplayMenu()
        {
            while(true)
            {
                Console.WriteLine("Welcome to SmartPowerGrid. Please Enter Your ID: ");
                var id = Console.ReadLine();
                var prosumer = loginManager.ValidateLogin(Int32.Parse(id));
                if (prosumer != null)
                {
                    Console.WriteLine("Welcome " + prosumer.firstname + prosumer.lastname);
                    Console.WriteLine("Directing to Transactionmenu");
                    transactionMenu.DisplayMenu();
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