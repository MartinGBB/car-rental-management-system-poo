## Sistema de Gerenciamento de Aluguel de Carros (Prática de POO)
Este projeto é uma aplicação de console desenvolvida em C#, que serve como um sistema básico de gerenciamento de aluguel de carros. Exercicio proposto pela trybe para praticar conceitos de Programação Orientada a Objetos (POO), incluindo herança, encapsulamento e polimorfismo. A aplicação permite gerenciar uma frota de veículos, como carros, motocicletas e caminhonetes, e processar transações de aluguel.
## Estrutura do Projeto
* Gerenciamento de Veículos: Criação e gerenciamento de diferentes tipos de veículos, como carros, motocicletas e caminhonetes.
* Processo de Aluguel: Simulação do processo de aluguel com diferentes tipos de clientes e cálculo de taxas de aluguel com base no tipo de veículo e na duração do aluguel.
* Enumeração para Atributos: Uso de enums para atributos como tipo de combustível, tipo de freio e tipo de tração.

## Execução do Projeto
Para executar o projeto, siga os passos abaixo:

1. Clone o repositório:
  ``` zsh
  git clone git@github.com:MartinGBB/csharp-001-projeto-trybank.git
  cd trybank
  ```

2. Restaure os pacotes NuGet necessários:
  ``` zsh
  dotnet restore
  ```
3. Compile e execute a aplicação:
  ```sh
  dotnet run --project RentCars
  ```