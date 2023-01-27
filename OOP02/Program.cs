using OOP02.Models;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportCompany transportCompany1 = new TransportCompany("Orange", "France", "1234567890");
            Console.WriteLine("**************Welcome to my Company************");

            var myNewVehicle = new Vehicle("BWM","BMW","RedDark",DateTime.Now.AddYears(-50));
            transportCompany1.AddVehicle(myNewVehicle);

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Please press on Enter key to continue");
                key = Console.ReadKey();

            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine($"------------------{transportCompany1.Name.ToUpper()}---------------");
            transportCompany1.ShowCatalog();
            Console.ReadKey();
        }
    }
}