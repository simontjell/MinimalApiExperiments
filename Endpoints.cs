namespace MinApiSample
{
    public class Endpoints
    {
        public static Greeting Greet(HttpContext httpContext, HelloService helloService, Person person) 
        {
            if(string.IsNullOrEmpty(person.Name))
            {
                httpContext.Response.StatusCode = 400;
                return new Greeting(null!, ValidationError: $"{nameof(Person.Name)} cannot be empty");
            }
            return helloService.SayHello(person.Name);
        }
    }
}
