    public interface IGreetingEndpoint
    {
        Greeting Greet(HttpContext httpContext, Person person);
    }

    public class GreetingEndpoint : IGreetingEndpoint
    {
        private IHelloService _helloService;

        public GreetingEndpoint(IHelloService helloService)
            => (_helloService) = (helloService);

        public Greeting Greet(HttpContext httpContext, Person person) 
        {
            if(string.IsNullOrEmpty(person.Name))
            {
                httpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                return new Greeting(null!, ValidationError: $"{nameof(Person.Name)} cannot be empty");
            }
            return _helloService.SayHello(person.Name);
        }
    }
