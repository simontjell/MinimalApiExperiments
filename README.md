# Minimal API Experiments
This repository contains some of my initial experiments playing around with the new minimal API features of the ASP.NET 6 framework - i.e., no Startup class, implicit namespace inclusions, and no explicit controllers. It also contains the result of trying to exploit the (fairly) new record types in order to minimize the code concerned with exoressing API contracts.

# Running
The project can be run with ```dotnet watch run```, which will enable hot reload when code files are changed.
When the web application has been built and is running, the base URL is shown in the console, e.g. https://localhost:7297.
Based on the base URL, the Swagger UI can be found in /swagger (e.g., https://localhost:7297/swagger), and from here, the various endpoint along with their contracts can be found and tested out directly in the browser.

# Calling
The Greeting endpoint (at /hello) can be called using Curl:
```bash
curl -X 'POST' -k 'https://localhost:7297/hello' -H 'accept: application/json' -H 'Content-Type: application/json' -d '{ "name": "Simon" }'
```

...resulting in a response like this:
```json
{"message":"Hello, Simon!","validationError":null}
```

And the time endpoint (at /time) can be called in this way:
```bash
curl -X 'GET' -k 'https://localhost:7297/time' -H 'accept: application/json'
```

...which gives a result like this:
```json
{"hours":10,"minutes":45,"seconds":34}
```

Please note the ```-k``` parameter, which tells Curl to ignore the autenticity of the homemade ASP.NET development certificate.
