README.md
# dotnet Microservices Kit

The goal is to build a framework that can make building microservices in dotnet easy for developers. This project follows Vertical Slice Architecture along with other latest best practices and tools like CQRS, NoSQL, SQL, MediatR, Serilog, FluentValidations and more.🚀

# Table of Contents

- [dotnet Microservices Kit](#net-microservices-boilerplate)
- [Table of Contents](#table-of-contents)
  - [Goals](#goals)
  - [DotMK](#DotMK)
  - [How to Run ?](#how-to-run-)
    - [Tye](#tye)
    - [Docker \& Docker-Compose](#docker--docker-compose)
  - [Technologies \& Libraries](#technologies--libraries)
  - [Documentation](#documentation)
  - [Changelogs](#changelogs)
  - [Community](#community)
  - [License](#license)
  - [Support ⭐](#support-)
  - [Code Contributors](#code-contributors)
  - [Financial Contributors](#financial-contributors)


## Goals

- :sparkle: Using `Vertical Slice Architecture` for architecture level.
- :sparkle: Using `Domain Driven Design (DDD)` to implement all business processes in microservices.
- :sparkle: Using `Rabbitmq` on top of `MassTranit` for `Event Driven Architecture` between our microservices.
- :sparkle: Using `CQRS` implementation with `MediatR` library.
- :sparkle: Using `Entity Framework Core` for some microservices.
- :sparkle: Using `MongoDB` for some microservices.
- :sparkle: Using `Fluent Validation` and a `Validation Pipeline Behaviour` on top of `MediatR`.
- :sparkle: Using `Minimal API` for all endpoints.
- :sparkle: Using `Health Check` for reporting the health of app infrastructure components.
- :sparkle: Using `Tye` for local development and debugging.
- :sparkle: Using `Built-In Containerization` for `Docker` images.
- :sparkle: Using `Zipkin` for distributed tracing.
- :sparkle: Using `OpenIddict` for authentication and authorization base on `OpenID-Connect` and `OAuth2`.
- :sparkle: Using `Yarp` as a microservices gateway.
- :sparkle: Multitenancy
- :sparkle: Service template

## Project core base

"Project core base" is a sample project that consumes the microservice framework. You will learn a lot by exploring this project.


| Services          | Status         |
| ----------------- | -------------- |
| Gateway           | Completed ✔️   |
| Identity          | Completed ✔️   |
| Catalog           | Completed ✔️   |
| Cart              | WIP       🚧   |
| People            | WIP       🚧   |
| Ordering          | WIP       🚧   |
| Payment           | WIP       🚧   |

## How to Run ?

### Tye
Tye is a super-awesome way to run your applications quickly. T

```
make tye
```

That's it! 

This will spin up all the services required. 
- Gateway will be available on `https://localhost:7002`.
- Identity Service will be available on `https://localhost:7001`.
- Catalog Service will be available on `https://localhost:7003`.

### Docker & Docker-Compose
The project comes included with the required docker-compose.yaml and makefile file for your reference.

There are some prerequisites for using these included docker-compose.yml files:

1) Make sure you have docker installed (on windows install docker desktop)

2) Create and install an https certificate:

    ```
    dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\cert.pfx -p password!
    ```

    Note that the certificate name and password should match the ones that are mentioned in the docker-compose.yaml file.

3) It's possible that the above step gives you an `A valid HTTPS certificate is already present` error.
   In that case you will have to run the following command, and then  `Re-Run Step #2`.

    ```
     dotnet dev-certs https --clean
    ```

4) Trust the certificate

    ```
     dotnet dev-certs https --trust
    ```
Once your certificate is trusted, simply navigate into the `./DotMK` folder of the project and run the following command.

```
make docker-up
```

This will spin up all the containers required. Your Gateway URL will be available on `https://localhost:7002`.

To bring down all the `DotMK` container, simply run the following.

```
make docker-down
```

*Note that the default Docker Images that will be pulled are from my public Image Repository (for eg, `iammukeshm/DotMK.identity:latest`). You can switch it your variants if required.*

## Technologies & Libraries

- **[`.NET 7`](https://dotnet.microsoft.com/download)** - .NET Framework and .NET Core, including ASP.NET and ASP.NET Core
- **[`MVC Versioning API`](https://github.com/microsoft/aspnet-api-versioning)** - Set of libraries which add service API versioning to ASP.NET Web API, OData with ASP.NET Web API, and ASP.NET Core
- **[`EF Core`](https://github.com/dotnet/efcore)** - Modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations
- **[`MediatR`](https://github.com/jbogard/MediatR)** - Simple, unambitious mediator implementation in .NET.
- **[`FluentValidation`](https://github.com/FluentValidation/FluentValidation)** - Popular .NET validation library for building strongly-typed validation rules
- **[`Swagger & Swagger UI`]()** - Swagger tools for documenting API's built on ASP.NET Core
- **[`Serilog`](https://github.com/serilog/serilog)** - Simple .NET logging with fully-structured events
- **[`OpenIddict`](https://github.com/openiddict/openiddict-core)** - OpenIddict aims at providing a versatile solution to implement OpenID Connect client, server and token validation support.
- **[`Mapster`](https://github.com/MapsterMapper/Mapster)** - Convention-based object-object mapper in .NET.
- **[`Yarp`](https://github.com/microsoft/reverse-proxy)** - Reverse proxy toolkit for building fast proxy servers in .NET
- **[`Tye`](https://github.com/dotnet/tye)** - Developer tool that makes developing, testing, and deploying microservices and distributed applications easier.
- **[`MongoDB.Driver`](https://github.com/mongodb/mongo-csharp-driver)** - .NET Driver for MongoDB.

## Documentation


## Changelogs

## Community

## License

This project is licensed with the [MIT license](LICENSE).


## Support ⭐

Has this Project helped you learn something New? or Helped you at work?
Here are a few ways by which you can support.

-   Leave a star! ⭐
-   Recommend this awesome project to your colleagues. 🥇
-   [consider buying me a coffee](https://buymeacoffee.com/nguyencaoan
)! ☕


## Code Contributors

This project exists thanks to all the people who contribute.

## References
[Template](https://github.com/thirschel/dotnet-cqrs-microservice-template)

