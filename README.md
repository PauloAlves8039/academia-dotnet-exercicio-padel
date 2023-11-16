<h1 align="center">Academia .NET - Desafio Padel</h1>

## :computer: Projeto

Repositório com solução de desafio para gerenciar listas sobre uma modalidade esportiva chamada `Padel`, o desafio foi proposto durante a Academia .NET ministrada pela `Universidade Franciscana - UFN`.

## :page_facing_up: Desafio

[Descrição do Desafio](https://github.com/ricardosma/academia_DotNet_5/blob/main/anotacoesAlexandre/aulas.md)

## :scroll: Funcionalidades

Essa aplicação permite ao usuário:

- Cadastrar `Nome`, `Email` e `Data de Nascimento` da `Pessoa`, essa classe vai ser usada em herança pelas outras classes de modelo.
- Cadastrar `Posicão na Quadra` e `Categoria` da entidade `AtletaPadel`, esta classe herda da classe `Pessoa` as suas propriedades.
- Cadastrar `Registro Conselho` e `Clube` da entidade `TreinadorPadel`, esta classe herda da classe `Pessoa` as suas propriedades. 
- Visualizar duas listas: `Lista de Atletas` e `Lista de Treinadores`.
- Remover `Atleta` ou `Trienador`.
- Validações de todos campos das classes de modelo.

## :white_check_mark: Decisões Técnicas

Fiz a criação de pastas visando uma organização na estrutura do projeto, cada pasta representa a definição de cada uma das classes utilizadas:

- <b>Models</b>: essa pasta é responsável por armazenar as classes de modelo, nela foram criadas as classes `Pessoa` `AtletaPadel` e `TreinadorPadel`.
- <b>Communications</b>: nesta pasta são armazenadas as classes `ComunicacaoAtleta` e `ComunicaoTreinador`, que possuem métodos responsáveis pela regra de negócio da aplicação, eu optei em usar essa nomeclatura para tentar seguir o mesmo exemplo apresentado em aula.
- <b>Utils</b>: esta pasta contem a classe `Utilitario`, o seu objetivo é definir métodos auxiliares para as validações das propriedades e outras funcionalidades.

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- `Console Application`
- ``C#``

## :floppy_disk: Clonar Repositório

```git clone https://github.com/PauloAlves8039/academia-dotnet-exercicio-padel.git```

## Author
:boy: [Paulo Alves](https://github.com/PauloAlves8039)

