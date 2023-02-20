namespace MyBank.Models
{
    public class Account : BaseEntity
    {
        public string AccountNumber { get; set; }
        public decimal AmountOfMoney { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
