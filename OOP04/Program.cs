using OOP04.Models;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var trader = new TradeCompany("SupermanTrader", "simple trader's comp",
               DateTime.Now.AddYears(-10), true);

                var rental = new RentalCompany("RentalRentaler", "rental car company with % per rent",
                    DateTime.Now.AddYears(-20), true, default);



                Console.WriteLine("Company: {0} Year of activities : {1} Type:{2}", trader.Name,
                    trader.CalculateAges(), trader.GetType().Name);

                Console.WriteLine("Company: {0} Year of activities : {1} Type:{2}", rental.Name,
                    rental.CalculateAges(), rental.GetType().Name);

                trader.ThrowsExceptionWhenCalled();
            }
            catch (MyException ex)
            {
                if (ex is ArgumentNullException)
                    Console.WriteLine("you forgot to pass the arg");
                else
                    Console.WriteLine($"status:{ex.Status} Msg : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("the application will be closed");
            }
        }
    }
}