<img align="left" width="116" height="116" src="https://raw.githubusercontent.com/rcarneironet/valhalla-clean-architecture/master/valhalla-logo.png" />

Esse repositório é uma implementação de uma Arquitetura Clean (Clean Architecture) usando .NET Core.

O foco é ter um estudo de caso e uma arquitetura base onde você consiga entender a importância de ter uma aplicação desacoplada de frameworks e tecnologias de uma forma que seu software represente mais o contexto de negócio que você está inserido(a) e não uma implementação baseada em regras de negócios de banco de dados.

## Tecnologias
* .NET Core 3.1
* Entity Framework Core 3.1
* Dapper
* Angular 8

## Sobre Clean Architecture e suas responsabilidades

### Domínio (Domain)

Essa camada é responsável por todas as suas entidades, enumerações, exceçÕes, abstrações (interfaces por exemplo), tipos e lógicas específicas ao seu domínio.

### Aplicação (Application)

Essa camada é responsável por toda lógica da sua aplicação. Ela depende da camada de domínio mas não tem dependência com nenhuma outra camada ou projeto. Essa camada descreve abstrações que são implementadas nas camadas de fora.

Se por acaso você precisar implementar um acesso a dados, por exemplo o Entity Framework, essa implementação ficaria fora dessa camada (em infraestrutura), porém a abstração seria implementada aqui. 

### Infraestrutura (Infrastructure)

Essa camada é responsável por conter classes que acessem recursos externos a nossa aplicação, como por exemplo web services, emails ou até mesmo acesso a disco. Essas classes devem implementar abstrações da camada de aplicação.

### Interface de Usuário (UI)

Essa camada é responsável pela interface de usuário, no caso desse projeto temos um exemplo simples utilizando Angular 8 e ASP.NET Core 3. Essa camada depende da aplicação e infraestrutura porém toda dependência que vier de infraestrutura é apenas para consumir injeção de dependências. 

## Suporte

Se você quiser participar ou encontrar problemas, abra um issue [aqui](https://github.com/rcarneironet/valhalla-clean-architecture/issues/new).

Se de alguma forma o projeto foi útil para você ou sua empresa, dê uma estrela e siga o projeto!


