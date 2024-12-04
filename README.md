# Ambev Ominia Test

## Conteúdo

- [Tecnologias](#tecnologias)
- [Instalação](#instalação)
  - [Clone o repositório](#clone-o-repositório)
  - [Subir o container](#subir-o-docker-compose)
  - [Atualize o banco de dados](#atualize-o-banco-de-dados)
- [Como Funciona](#como-funciona)
  - [Subir API](#subir-api)
  - [Visualizar a Documentação](#visualizar-a-documentação)

### Tecnologias

- [ASP.NET Core](https://dotnet.microsoft.com/pt-br/apps/aspnet)
- [EF Core](https://learn.microsoft.com/pt-br/ef/core/)
- [Docker](https://www.docker.com/)

### Instalação

#### clone o repositório

abra o seu terminal e digite o comando abaixo:

```bash
git clone https://github.com/mpalmeidagit/ambev-ominia-test.git
```

#### subir o docker compose

ainda no mesmo terminal digite:

```bash
cd ambev-ominia-test
```

após digite o comando abaixo para subir o container conforme descrito no arquivo `docker-compose.yml`:

```bash
docker-compose up -d
```

#### atualize o banco de dados
  
agora, deve-se ir para pasta do projeto que possui as migrations(migrações). Digite:

```bash
cd src/Ambev.DeveloperEvaluation.ORM
```

após, execute o comando abaixo para atualizar o banco dados dentro do container.

```bash
dotnet ef database update
```

### Como Funciona

#### subir API

deve ir para o projeto WebApi

```bash
cd src/Ambev.DeveloperEvaluation.WebApi/
```

utilize o comando abaixo para rodar subir API.

```bash
dotnet run
```

#### visualizar a documentação

abra o navegador e acessa a url abaixo para visualizar a documentação

```bash
http://localhost:5119/swagger/
```
