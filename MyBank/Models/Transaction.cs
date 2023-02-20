namespace MyBank.Models
{
    public class Transaction : BaseEntity
    {

        /// <summary>
        /// The sender of the money. means user Id(sender user)
        /// </summary>
        public int Sender { get; set; }

        /// <summary>
        /// The receiver user id.
        /// </summary>
        public int Receiver { get; set; }

        public decimal AmountSent { get; set; }
        public DateTime DateTime { get; set; }
    }
}
