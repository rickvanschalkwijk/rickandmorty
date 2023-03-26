# rickandmorty


## Notes

#### sonarcloud
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=rickandmorty&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=rickandmorty)

#### package.json
The `package.json` file was created to allow to use the tools:
- [Husky](https://typicode.github.io/husky/#/)
- [commitlint](https://commitlint.js.org/#/)
- [semantic-release](https://github.com/semantic-release/semantic-release#readme)

#### Database

Database was provided using [docker-compose](https://docs.docker.com/compose/):

File: `/database/docker-compose.yml`

To start: 
```bash
docker-compose up -d
```

To stop: 
```bash
docker-compose down
```

