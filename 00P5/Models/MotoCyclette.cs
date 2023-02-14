using _00P5.Interfaces;

namespace _00P5.Models
{
    public class MotoCyclette : ICar
    {
        public void DecreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void EncreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StartEngine(string key)
        {
            Console.WriteLine("engine stopped");
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine(string key)
        {
            throw new NotImplementedException();
        }
    }
}
