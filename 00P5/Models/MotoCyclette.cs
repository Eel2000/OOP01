using _00P5.Interfaces;

namespace _00P5.Models
{
    public class MotoCyclette : ICar
    {
        public IList<string>? Tags { get; set; }
        public float MaxSpeed { get; set; }
        public string Make { get ; set ; }
        public string Conductor { get ; set ; }
        public float ConductorSpeed { get; set; }

        public void DecreaseSpeed()
        {
            throw new NotImplementedException();
        }


        public void DecreaseSpeed(int speed)
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
