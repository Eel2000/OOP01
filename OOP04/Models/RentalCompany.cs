using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Models
{
    public class RentalCompany : Company
    {
        public float PercentagePerRent { get; set; } = 4.5f;

        public RentalCompany(string name, string description, DateTime creationDate, bool isActive, float percentagePerRent) : base(name, description, creationDate, isActive)
        {
            PercentagePerRent = percentagePerRent;
        }
    }
}
