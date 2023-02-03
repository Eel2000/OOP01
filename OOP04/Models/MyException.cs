using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Models
{
    public class MyException : Exception
    {
        public string Status { get; set; }
        public MyException(string status, string message) : base(message)
        {
            Status = status;
        }
    }
}
