# Exercício de ProjOO - Padrão Facade (Home Theater)

Este repositório contém a resolução do exercício sobre o padrão de projeto **Facade** (Fachada), aplicado a um sistema de Home Theater, conforme orientado pelo Prof. Fábio Fagundes Silveira.

## O que eu fiz no projeto:
A ideia principal foi simplificar a interação do usuário com um sistema complexo. Em vez de obrigar o cliente a ligar e configurar cada aparelho (Luz, Som, Streaming) individualmente, criei uma **Fachada** que resolve tudo com um único comando.

## Padrão Utilizado:
- **Facade**: Usei para esconder a complexidade dos subsistemas. A classe `HomeTheaterFacade` oferece métodos simples como `AssistirFilme()` e `EncerrarFilme()`, que coordenam internamente todas as ações necessárias nos dispositivos.

## Estrutura dos arquivos:

- **Luzes.cs, Som.cs, Streaming.cs**: São os subsistemas (aparelhos). Cada um tem suas próprias funções específicas.
- **HomeTheaterFacade.cs**: É a classe de Fachada. Ela conhece todos os aparelhos e organiza a ordem de inicialização e desligamento de cada um.
- **Program.cs**: Arquivo de testes onde demonstrei como o cliente interage apenas com a Fachada, reduzindo o acoplamento e facilitando o uso do sistema.

## Como rodar o código:
O repositório já contém o arquivo de projeto (`.csproj`). Para executar, basta abrir a pasta no terminal e digitar:

```bash
dotnet run
