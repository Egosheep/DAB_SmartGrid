using System;

namespace SmartGrid_ServerApp
{
    public class ConsolePrinter : IConsolePrinter
    {
        public void PrinterCenteredHeader(string text)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text);
        }
    }
}