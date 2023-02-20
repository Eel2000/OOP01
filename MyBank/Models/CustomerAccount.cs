namespace MyBank.Models
{
    public class CustomerAccount : BaseEntity
    {

        /// <summary>
        /// the account id
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// the account's owner id.
        /// </summary>
        public Guid CustomerId { get; set; }
    }
}
