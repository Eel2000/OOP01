using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00P031.Models
{

    /// <summary>
    /// Remove the abstract key work if you need the create an instance of this class(company) itself
    /// </summary>
    public class Company
    {
        public Company(string name, string phoneNo, string address)
        {
            Name = name;
            PhoneNo = phoneNo;
            Address = address;
            Employees = new List<string>();
        }

        public string Name { get;  private set; }
        public string PhoneNo { get; private set; }
        public string Address { get; private set; }
        public List<string> Employees { get;  private set; }


        public void AddEmployee(string employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(string employee)
        {
            Employees.Remove(employee);
        }


    }
}
