using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00P031.Models
{
    public class RentalCompany : Company
    {
        public decimal Percentage { get; private set; }

        public RentalCompany(string name, string phoneNo, string address, decimal percentage) : base(name, phoneNo, address)
        {
            Percentage = percentage;
        }

        public decimal ChangePercentage(decimal changePercentage)
        {
            Percentage = changePercentage;
            return Percentage;
        }
    }
}
