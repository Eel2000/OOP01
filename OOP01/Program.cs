using OOP01.Models;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Restaurant myRestaura = new Restaurant("KFC", "9876543", "unknown");


            myRestaura.AddMenuItem("Coffee", "Cup black coffee hot", 5m);


            //MenuItem myNewMenuItem = new MenuItem("Coffee", "Cup black coffee hot", 5m);
            //MenuItem myNewMenuItem2 = new MenuItem("Coffee", "Cup black coffee cold", 5m);
            //myNewMenuItem.EditTheDescription("No description");
            //myRestaura.AddMenuItemToMenu(myNewMenuItem);
            //myRestaura.AddMenuItemToMenu(myNewMenuItem2);

            Console.WriteLine($"My restaurant name is :{myRestaura.Name}\n and the phone : {myRestaura.Telephone} and the address is  :{myRestaura.Address}");

            var clients = new int[] { 1, 2, 3, 4, 5 };
            foreach(int client in clients )
            {
                myRestaura.RingTheBellForEveryNewClient();
                myRestaura.PrintWelcomeMessage();
                Task.Delay(1000).Wait();
                myRestaura.GreetingExistingCustomerAndGiveMenu($"{client}");
                Task.Delay(1000).Wait();
            }

            Console.ReadKey();
        }
    }
}