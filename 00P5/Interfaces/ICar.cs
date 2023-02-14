namespace _00P5.Interfaces
{
    public interface ICar
    {
        public void StartEngine();
        public void StopEngine();
        public void StopEngine(string key);
        public void StartEngine(string key);
        public void EncreaseSpeed();
        public void DecreaseSpeed();
    }
}
