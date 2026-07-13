# Learnify

This project is a platform for online courses. The user can browse and purchase courses by category, watch lectures section by section, and track learning progress. Built as a .NET Web API backend with a React client.

## Tech stack

**API** ASP.NET Core 6 (`API`), Entity Framework Core, SQLite, ASP.NET Identity for auth (JWT via `TokenService`), Stripe for payments, AutoMapper, Swashbuckle (Swagger).

**Client** React 18 + TypeScript, Redux Toolkit, React Router, Ant Design, Axios, Stripe.js.

## Project structure

```
API/              ASP.NET Core Web API controllers, DTOs, middleware, error handling
Entity/           Domain entities, repository interfaces, and specifications
Infrastructure/   EF Core DbContext, repositories, migrations, seed data, services (payments, tokens)
client/           React frontend
```

## Prerequisites

- .NET SDK 6.0.428 (see `global.json`)
- Node.js and npm
- `dotnet-ef` CLI tool: `dotnet tool install --global dotnet-ef --version 5.0.17`
- SQLite is used by default (`API/appsettings.Development.json`)

## Setup

Install dependencies for both projects:

```
make install
```

Configure the API by adding a connection string and any required secrets (e.g. Stripe keys, JWT signing key) via `API/appsettings.Development.json` or `dotnet user-secrets`.

Apply database migrations:

```
make migrate
```

## Running

```
make run           # runs API and client together
make run-api       # API only
make run-client    # client only
```

The API also exposes Swagger UI for exploring the available endpoints.

## Building

```
make build
```

## Other commands

```
make migrate       # apply EF Core database migrations
make clean         # remove build artifacts
make help          # list all available targets
```
