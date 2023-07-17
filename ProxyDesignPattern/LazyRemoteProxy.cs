namespace ProxyDesignPattern
{
    public class LazyRemoteProxy : IRemote
    {
        private Remote remote = null;
        public void TurnOff()
        {
            if (remote == null) remote = new Remote();
            remote.TurnOff();
        }

        public void TurnOn()
        {
            if(remote ==null) remote= new Remote();
            remote.TurnOn();
        }
    }
}
