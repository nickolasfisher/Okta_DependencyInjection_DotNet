# Dependency Injection in .NET 5

This repository shows you how to set write, register, and use services in an ASP.NET Core application.. Please read [A Comparison of .NET Depedency Injection Methods][blog] to see how it was created.

**Prerequisites:**

- [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

> [Okta](https://developer.okta.com/) has Authentication and User Management APIs that reduce development time with instant-on, scalable user infrastructure. Okta's intuitive API and expert support make it easy for developers to authenticate, manage and secure users and roles in any application.

* [Getting Started](#getting-started)
* [Links](#links)
* [Help](#help)
* [License](#license)

## Getting Started

### Obtain an Okta API Token

Navigate to your Okta admin panel.  Naviate to the `API` page and the `Tokens` tab on that page.  

Click **Create Token**.  Give it a meaningful name and keep track of it for use in your application.  

### Run the Application

To run this example, run the following commands:

```bash
git clone https://github.com/nickolasfisher/Okta_DependencyInjection_DotNet.git
cd OktaDependencyInjection
```

Create a file called `appsettings.Development.json` and add the following code to it.

```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "Okta": {
    "ClientId": "",
    "Domain": "{yourOktaDomain}",
    "Token": "{yourAPIToken}"
  }
}
```

Start debugging your application.

## Links

This example uses the following open source libraries from Okta:

* [Okta .NET SDK](https://github.com/okta/okta-sdk-dotnet)
* [Okta CLI](https://github.com/okta/okta-cli)

## Help

Please post any questions as comments on the [blog post][blog], or visit our [Okta Developer Forums](https://devforum.okta.com/).

## License

Apache 2.0, see [LICENSE](LICENSE).

[blog]: ()