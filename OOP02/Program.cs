using OOP02.Models;

namespace OOP02
{
    internal class Program
    {
        //TODO: add behavior for (Ordering a vehicle)
        static void Main(string[] args)
        {
            TransportCompany transportCompany1 = new TransportCompany("Orange", "France", "1234567890");
            Console.WriteLine("**************Welcome to my Company************");

            var myNewVehicle = new Vehicle("AUDI","AUDI","GRAY",DateTime.Now.AddYears(-40));
            var myNewVehicle2 = new Vehicle("FORD","FORD","Blue",DateTime.Now.AddYears(-35));

            transportCompany1.AddVehicle(myNewVehicle); //old one
            transportCompany1.Vehicles.Add(myNewVehicle2); //new one
            transportCompany1.AddVehicle2("BWM", "BMW", "RedDark", DateTime.Now.AddYears(-50));

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