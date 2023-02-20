using _00P5.Interfaces;
using _00P5.Models;

namespace _00P5
{
    internal class Program
    {
        static ICar myCard = new Car(120.0f, "VW", 0.0f);
        static ICar myCardV2 = new CarV2(120.0f, "VW", 0.0f);
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            ICar moto = new MotoCyclette();
            var withEngine = (IEngine)myCard;

            myCard.StartEngine("myKey");
            myCard.StartEngine();

            moto.StartEngine("myKey");
            withEngine.GetEngine();


            Greating();
        }

        static void Greating()
        {
            myCardV2.StartEngine();
            myCardV2.StopEngine();
        }
    }
}