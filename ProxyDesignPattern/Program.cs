// See https://aka.ms/new-console-template for more information
using ProxyDesignPattern;

IRemote remoteProxy = new LazyRemoteProxy();

remoteProxy.TurnOn();
remoteProxy.TurnOff();

Console.WriteLine("Hello, World!");
