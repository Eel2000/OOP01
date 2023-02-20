using _00P5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00P5.Models
{
    public class CarV2 : ICar
    {
        public CarV2(float maxSpeed, string make, float conductorSpeed)
        {
            MaxSpeed = maxSpeed;
            Make = make;
            ConductorSpeed = conductorSpeed;
        }

        public float MaxSpeed { get; set; }
        public string Make { get ; set ; }
        public string Conductor { get ; set ; }
        public float ConductorSpeed { get; set; }



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
            Console.WriteLine("Engine started withount key");
        }

        public void StartEngine(string key)
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            Console.WriteLine("try to stop engine please wait...");
        }

        public void StopEngine(string key)
        {
            throw new NotImplementedException();
        }
    }
}
