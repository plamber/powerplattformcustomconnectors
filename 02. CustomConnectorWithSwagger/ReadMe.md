## How to create a custom connector for Microsoft Flow

You can extend the capabilities in Microsoft Flow by implementing your own custom connectors providing 
Microsoft Flow's functionality can be extended further with custom connectors

This solution implements two REST services that can be used for a custom connector in Microsoft Flow.
- ProductsController: a service returning products that does not require any authentication
- SecuredHeaderProdutsController: a service returning products that requires a secure header for accessing the contents

## How to set it up
In general you need to follow these steps:
- Deploy the current solution to a remote repository (e.g. an Azure AD web app). Get the URL of the host
- Get the Swagger describing the current 

- Deploy the solution to an Azure AD web app. Get the URL
- Take the URL and replace it under appsettings.json under "host". This is required to generate the proper swagger file you need to register the connector


Implementa due semplici servizi REST per un custom connector che puo' essere sfruttato in Microsoft Flow.
- ProductsController: un servizio rest senza au