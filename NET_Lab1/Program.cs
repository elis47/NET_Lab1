using System;
using ClassLibrary;

namespace ASPNET_Lab1
{
    public class Program
    {
        private static void Main()
        {
            AlertService alertService = new AlertService();
            Console.WriteLine(alertService.ToString());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
