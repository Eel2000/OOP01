namespace OOP04.Models
{
    public sealed class TradeCompany : Company
    {

        public TradeCompany(string name, string description, DateTime creationDate, bool isActive) : base(name, description, creationDate, isActive)
        {
        }

        public override int CalculateAges()
        {
            int breakPeriod = 4, covid = 1;

            return DateTime.Now.Year - (breakPeriod + covid) - CreationDate.Year;
        }

        public static explicit operator TradeCompany(RentalCompany v)
        {
            ArgumentNullException.ThrowIfNull(v);
            return new TradeCompany(v.Name, v.Description, v.CreationDate, v.IsActive);
        }

        public void ThrowsExceptionWhenCalled()
        {
            throw new MyException("Error", "This is my custom exception");
        }
    }
}
