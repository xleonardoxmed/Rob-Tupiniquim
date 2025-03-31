# ROBÔ TUIPINIQUIM: DESBRAVANDO O COSMOS
![](https://i.imgur.com/4dOwz8x.gif)

### Robô Tupiniquim é um jogo onde você deve controlar dois robôs para explorar um terreno de tamanho personalizado, comandando-os para realizar movimentos específicos, como girar à esquerda, girar à direita e mover para frente. O objetivo do jogo é guiar os robôs ao longo do terreno sem colidir entre si, explorando e aprendendo enquanto navegam pelo cosmos.

## Tecnologias Utilizadas
C# (CSharp)

.NET Framework

Console Application

# Funcionalidades

1. Exibição do Terreno
O terreno é representado por um plano cartesiano bidimensional.

	Cada coordenada do terreno possui um valor (X, Y) para a posição do robô.

	O robô pode ser visualizado na tela com símbolos diferentes para indicar a sua direção.

2. Comandos do Robô
Entrada do Usuário:

	Coordenada inicial: Você deve fornecer a coordenada (X, Y) e a direção para o robô inicial (Norte - N, Sul - S, Leste - L, Oeste - O).

	Comandos de Movimento: O usuário pode inserir sequências de comandos como E, D ou M para o movimento do robô:

	- E: Girar 90° para a esquerda.

	- D: Girar 90° para a direita.

	- M: Mover o robô na direção em que está apontando.

3. Detecção de Colisão
O jogo verifica se os robôs colidem após cada movimento.
	
	Se os robôs se sobrepõem, a função ExplodeIFCollide() detecta essa colisão.

4. Validação
O código inclui validações para garantir que:

	As coordenadas inseridas são dentro dos limites definidos pelo terreno.

	Os comandos inseridos são válidos (E, D, M).

	A entrada de coordenadas é feita corretamente no formato X, Y, DIREÇÃO.

# Arquitetura do Jogo
Principais Classes
### 1 - Program.cs
Esta é a classe principal, onde o jogo é inicializado e executado. O fluxo do jogo segue um loop que:

- Mostra o painel do jogo.

- Exibe as regras e instruções.

- Inicia a exploração do terreno.

- Permite que o usuário decida se quer jogar novamente.

### 2. GameVisual.cs
Esta classe lida com a exibição do painel, regras do jogo, comandos de movimento, e a impressão do mapa do terreno com a posição dos robôs.

 #### Funções importantes:

 - ShowPannel( ): Exibe o painel inicial com o título e descrição do jogo.
	
 - ShowRules( ): Exibe as regras do jogo.
	
 - PrintMap( ): Desenha o terreno com a posição dos robôs.

 - MoveRobots( ): Atualiza as posições dos robôs com base nos comandos inseridos.
 
 - ExecuteCommand(): Processa os comandos de movimento (E, D, M).

### 3 - KindsOfValidation.cs
A classe de validação lida com a verificação da entrada do usuário e a manutenção da integridade do estado do jogo.

 ### Validações importantes:

- Coordenadas do robô e direção inicial.

- Comandos válidos para o robô.

- Detecção de colisão entre os robôs.

### 4 - GameLogic.cs
Esta classe gerencia a lógica do jogo, incluindo a movimentação dos robôs, execução de comandos e verificação de colisões.

# Como Jogar
### Passos Iniciais

- Defina o terreno: O jogo começa exibindo o tamanho do terreno. O tamanho do terreno pode ser escolhido na inicialização do jogo.

- Posicione os robôs: O jogador deve inserir as coordenadas iniciais para cada robô. As coordenadas devem estar no formato X, Y DIREÇÃO (exemplo: 0,0 N).

- Comandos de movimento: O jogador deve inserir uma sequência de comandos de movimento para guiar os robôs pela área explorada. Os comandos possíveis são:

- E: Gira o robô 90° para a esquerda.

- D: Gira o robô 90° para a direita.

- M: Move o robô para a frente.

## Fases do Jogo
- Exploração do Terreno: O jogador pode guiar os robôs para explorar o terreno, utilizando os comandos.

- Colisão: Se os robôs colidirem, o jogo detecta o erro e pode finalizar a partida ou reiniciar.

- Reinício: Após uma rodada, o jogo pergunta se o jogador deseja jogar novamente.

## Exemplo de Entrada
Coordenada inicial do robô: 0,0 N

Comandos de movimento: MMMRM

## Exemplo de Mapa
O mapa de 10x10 pode ser visualizado, com a posição dos robôs sendo representada pelos símbolos:

- '^' para o robô apontando para o norte (Norte).

- 'v' para o robô apontando para o sul (Sul).

-  '>' para o robô apontando para o leste (Leste).

- '<' para o robô apontando para o oeste (Oeste).

# Instruções de Execução
### Requisitos

- .NET SDK versão 5 ou superior.

- Um editor de texto (Visual Studio, Visual Studio Code ou similar).

- Clonar o repositório

- bash

# COMO JOGAR

- Clone o Repositório
```
git clone https://github.com/xleonardoxmed/Rob-Tupiniquim.git
```
Navegue até a pasta raiz da solução
```
cd RobôTupiniquim
```
Restaure as dependências
```
dotnet restore
```
Navegue até a pasta do projeto
```
cd RobôTupiniquim.ConsoleApp
```
Execute o projeto
```
dotnet run
```
# Se divirta explorando um novo planeta!!!