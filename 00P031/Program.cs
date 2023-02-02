using _00P031.Models;

namespace _00P031
{
    /// <summary>
    /// Inherintance && polymorphism
    /// </summary>
    internal class Program
    {
        public static List<Company> Companies = new List<Company>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! we'll create compiiiiies");

            //var general = new Company("gen", "57679875667", "Chennai");
            //general.AddEmployee("b");
            //general.AddEmployee("A");

            var rental = new RentalCompany("Cp", "098765654", "Gwanshu", 2m);
            rental.AddEmployee("Naresh");
            rental.AddEmployee("Bharath");

            var archiBuilder = new ArchitectCompany("poseidon", "585987658764738", "London");
            archiBuilder.AddEmployee("John");
            archiBuilder.AddEmployee("Luc");

            var superMan = new TransportCompany("Black Belt", "987657546456", "Lubumbashi", "OnGoing");
            superMan.AddEmployee("Batman");
            superMan.AddEmployee("Wonder wonan");

            Companies.Add(rental);
            Companies.Add(archiBuilder);
            Companies.Add(superMan);
            //Companies.Add(general);

            var t = Companies[0];

            foreach (var company in Companies)
            {
                Console.WriteLine("---------------------------------------------\n\r");
                Console.WriteLine($"Name: {company.Name} - Phone: {company.PhoneNo} - Type {company.GetType().Name}");
                Console.WriteLine("------------------Employees------------------");
                foreach (var employee in company.Employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}