namespace _00P031.Models
{
    public class TransportCompany : Company
    {
        public string Status { get; private set; }

        public TransportCompany(string name, string phoneNo, string address, string status) : base(name, phoneNo, address)
        {
            Status = status;
        }
    }
}
