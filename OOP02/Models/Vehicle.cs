using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Models
{
    public class Vehicle
    {
        public string Name { get; private set; }
        public string Mark { get; private set; }
        public string Color { get; private set; }
        public DateTime FabricationYear { get; private set; }

        public Vehicle(string name, string mark,string color, DateTime fabricationYear)
        {
            Name = name;
            Mark = mark;
            Color = color;
            FabricationYear = fabricationYear;
        }

        public string PrintVehicleDetails()
        {
            return $"Name: {Name} \n\rMark: {Mark} \n\rColor: {Color}";
        }
    }
}
