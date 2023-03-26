# rickandmorty

## Database

+ Database was provided using [docker-compose](https://docs.docker.com/compose/):
    + File: `/database/docker-compose.yml`

+ To start: 
```bash
docker-compose up -d
```

+ To stop: 
```bash
docker-compose down
```

## Running

+ To run the unit tests:
```bash
dotnet test
```

+ To run the console application:
```bash
dotnet run --project RickAndMorty.ConsoleApplication/RickAndMorty.ConsoleApplication.csproj
```

+ To run the web application:
```bash
dotnet run --project RickAndMorty.WebApplication/RickAndMorty.WebApplication.csproj
```

## github actions
[![On Merge Main](https://github.com/matheusaraujo/rickandmorty/actions/workflows/on-merge-main.yml/badge.svg)](https://github.com/matheusaraujo/rickandmorty/actions/workflows/on-merge-main.yml)

## sonarcloud
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=rickandmorty&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=rickandmorty)


## Notes
+ The `package.json` file was created to allow to use the tools:
    + [Husky](https://typicode.github.io/husky/#/)
    + [commitlint](https://commitlint.js.org/#/)
    + [semantic-release](https://github.com/semantic-release/semantic-release#readme)

