using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Models
{
    public class TransportCompany
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string PhoneNo { get; private set; }
        public List<Vehicle> Vehicles { get; set; }

        public TransportCompany(string name, string address, string phoneNo)
        {
            Name = name;
            Address = address;
            PhoneNo = phoneNo;

            //create an empty list each time we create a new company
            Vehicles = new List<Vehicle>();
        }

        /// <summary>
        /// add new compan
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine($"You've added the {vehicle.Name} vehicle to your catalog and store.");
        }


        public void AddVehicle2(string name, string mark, string color, DateTime fabYear)
        {
            var newV = new Vehicle(name, mark, color, fabYear);
            Vehicles.Add(newV);
            Console.WriteLine("added!");
        }


        public void ShowCatalog()
        {
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine($"{vehicle.Name} {vehicle.Mark} {vehicle.FabricationYear.Year}");
            }
        }

        public void RemoveVehiculeFromStore(string name)
        {
            var lookingVehicle = Vehicles.FirstOrDefault(vehicle => vehicle.Name.ToUpper() == name.ToUpper());
            if (lookingVehicle != null)
            {
                Vehicles.Remove(lookingVehicle);
                Console.WriteLine("Vehicle removed");
            }

            Console.WriteLine("vehicle your looking for not found");
        }
    }
}
