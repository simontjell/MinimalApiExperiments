public interface IHelloService
{
    Greeting SayHello(string name);
}


public class HelloService : IHelloService
{
    public Greeting SayHello(string name) => new Greeting($"Hello, {name}!");
}