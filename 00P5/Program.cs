using _00P5.Interfaces;
using _00P5.Models;

namespace _00P5
{
    internal class Program
    {
        static ICar myCard = new Car(120.0f, "VW", 0.0f);
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           

            ICar moto = new MotoCyclette();
            var withEngine = (IEngine)myCard;

            myCard.StartEngine("myKey");

            moto.StartEngine("myKey");
            withEngine.GetEngine();
        }

        static void Greating()
        {
            myCard.StartEngine();
        }
    }
}