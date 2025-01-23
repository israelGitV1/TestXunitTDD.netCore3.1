# TDD com Test Xunit Dotnet Core 3.1 

# Introdução

### Este projeto demonstra a implementação de TDD (Test-Driven Development) utilizando o framework de testes xUnit e a tecnologia .NET Core 3.1. O projeto consiste em uma aplicação de console para uma calculadora, que serve como base para implementar as regras de negócio e validar seu funcionamento através de testes automatizados.

### Principais Tecnologias e Funcionalidades:

 *  .net Core 3.1.
 *  Test XUnit.

###  Planejados:

   #### ConsoleApp:
* Uma Calculadora que contém Soma, Subtração, Divisão e Multiplicação e histórico de operações.
* Regras de negócios:
	- Números inteiros
	- 2 parâmetros por operação
	- Sempre retornar as últimas 3 operações do histórico
   #### TestConsoleApp:
   * TestSomar
   * TestSubitrair 
   * TestMultiplicar
   * TestDividir
   * TestDividirPorZero
   * TestHistorico

### Objetivos:

* Implementar todos as regras primeiro nos tests regando falhas.
* implementando as regras no consoleApp.
* Test regando resultados positivos.

Se precisar de ajuda com implementação ou ajustes, é só avisar!

## Requirements to run:

- .Net 3.1

## Running Api Test Instructions
1. Para rodar os testes de integração:
```
cd TestConsoleApp
```
```
dotnet test
```
## Observação
Este projeto foi desenvolvido como um exemplo educativo e pode ser expandido ou adaptado conforme a necessidade.

