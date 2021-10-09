public class HelloService
{
    public Greeting SayHello(string name) => new Greeting($"Hello, {name}!");
}