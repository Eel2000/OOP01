using _00P5.Interfaces;

namespace _00P5.Models;

public class Car : ICar,IEngine
{
    public Car(float maxSpeed, string make, float conductorSpeed)
    {
        MaxSpeed = maxSpeed;
        Make = make;
        ConductorSpeed = conductorSpeed;
    }

    public float MaxSpeed { get; set; }
    public string Make { get; set; }
    public string Conductor { get; set; }
    public float ConductorSpeed { get; set; } = 0.0f;

    public void StartEngine(string key)
    {
        Console.WriteLine("Engine started and it's running");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped");
    }

    public void EncreaseSpeed()
    {
        if (ConductorSpeed > MaxSpeed) return;

        ConductorSpeed += 0.5f;
        Console.WriteLine("Current speed is" + ConductorSpeed);
    }

    public void DecreaseSpeed()
    {
        if (ConductorSpeed < 0.0f) return;

        ConductorSpeed -= 0.5f;
        Console.WriteLine("Current speed is" + ConductorSpeed);
    }

    public void StartEngine()
    {
        throw new NotImplementedException("You need a key");
    }

    public void StopEngine(string key)
    {
        Console.WriteLine("Engine stopped using key");
    }

    public void GetEngine()
    {
        Console.WriteLine("My Engine");
    }
}
