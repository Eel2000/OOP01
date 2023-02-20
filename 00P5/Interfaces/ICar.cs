namespace _00P5.Interfaces
{
    public interface ICar
    {
        public float MaxSpeed { get; set; }
        public string Make { get; set; }
        public string Conductor { get; set; }
        public float ConductorSpeed { get; set; }

        public void StartEngine();
        public void StopEngine();
        public void StopEngine(string key);
        public void StartEngine(string key);
        public void EncreaseSpeed();
        public void DecreaseSpeed();
    }
}
