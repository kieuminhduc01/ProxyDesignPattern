namespace ProxyDesignPattern
{
    public class Remote : IRemote
    {
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
    }
}
