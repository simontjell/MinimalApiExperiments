# MinimalApiExperiments
This repository contains some of my initial experiments playing around with the new minimal API features of the ASP.NET 6 framework. It also contains the result of trying to exploit the (fairly) new record types in order to minimize the code concerned with exoressing API contracts.

# Running
The project can be run with ```dotnet watch run```, which will enable hot reload when code files are changed.
When the web application has been built and is running, the base URL is shown in the console, e.g. https://localhost:7297.
Based on the base URL, the Swagger UI can be found in /swagger (e.g., https://localhost:7297/swagger), and from here, the various endpoint along with their contracts can be found and tested out directly in the browser.
