namespace OOP01.Models
{
    public class Restaurant
    {
        public string Name { get; private set; }
        public string Telephone { get; private set; }
        public string Address { get; private set; }

        public List<MenuItem> Menu { get; private set; }

        public Restaurant(string name, string telephone, string address)
        {
            Name = name;
            Telephone = telephone;
            Address = address;
            Menu = new List<MenuItem>();
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine($"Welcome to {this.Name} Sir/Ms");
        }

        public void GreetingExistingCustomerAndGiveMenu(string name)
        {
            Console.WriteLine($"Hello {name}. how can we help you?\n here is our menu.");
            foreach (var item in Menu)
            {
                Console.WriteLine($"* {item.Title}_____ {item.Price} $____{item.Description}");
            }
        }

        public void RingTheBellForEveryNewClient()
        {
            Console.Beep(40,500);
            Console.WriteLine("Ring ring ring!!!");
        }

        public void AddMenuItemToMenu(MenuItem item)
        {
            Menu.Add(item);
            Console.WriteLine("new menu item added. menu was updated!");
        }

        public void AddMenuItem(string title, string description, decimal price)
        {
            var newMenuItem = new MenuItem(title, description, price);
            Menu.Add(newMenuItem);
            Console.WriteLine("new menu item added. menu was updated!");
        }

    }
}
