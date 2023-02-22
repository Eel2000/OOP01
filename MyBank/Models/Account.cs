namespace MyBank.Models
{
    public class Account : BaseEntity
    {
        public string AccountNumber { get; set; }
        public decimal Solde { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
