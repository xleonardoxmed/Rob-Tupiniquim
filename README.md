# ROB� TUIPINIQUIM: DESBRAVANDO O COSMOS
![](https://i.imgur.com/4dOwz8x.gif)

### Rob� Tupiniquim � um jogo onde voc� deve controlar dois rob�s para explorar um terreno de tamanho personalizado, comandando-os para realizar movimentos espec�ficos, como girar � esquerda, girar � direita e mover para frente. O objetivo do jogo � guiar os rob�s ao longo do terreno sem colidir entre si, explorando e aprendendo enquanto navegam pelo cosmos.

## Tecnologias Utilizadas
C# (CSharp)

.NET Framework

Console Application

# Funcionalidades

1. Exibi��o do Terreno
O terreno � representado por um plano cartesiano bidimensional.

	Cada coordenada do terreno possui um valor (X, Y) para a posi��o do rob�.

	O rob� pode ser visualizado na tela com s�mbolos diferentes para indicar a sua dire��o.

2. Comandos do Rob�
Entrada do Usu�rio:

	Coordenada inicial: Voc� deve fornecer a coordenada (X, Y) e a dire��o para o rob� inicial (Norte - N, Sul - S, Leste - L, Oeste - O).

	Comandos de Movimento: O usu�rio pode inserir sequ�ncias de comandos como E, D ou M para o movimento do rob�:

	- E: Girar 90� para a esquerda.

	- D: Girar 90� para a direita.

	- M: Mover o rob� na dire��o em que est� apontando.

3. Detec��o de Colis�o
O jogo verifica se os rob�s colidem ap�s cada movimento.
	
	Se os rob�s se sobrep�em, a fun��o ExplodeIFCollide() detecta essa colis�o.

4. Valida��o
O c�digo inclui valida��es para garantir que:

	As coordenadas inseridas s�o dentro dos limites definidos pelo terreno.

	Os comandos inseridos s�o v�lidos (E, D, M).

	A entrada de coordenadas � feita corretamente no formato X, Y, DIRE��O.

# Arquitetura do Jogo
Principais Classes
### 1 - Program.cs
Esta � a classe principal, onde o jogo � inicializado e executado. O fluxo do jogo segue um loop que:

- Mostra o painel do jogo.

- Exibe as regras e instru��es.

- Inicia a explora��o do terreno.

- Permite que o usu�rio decida se quer jogar novamente.

### 2. GameVisual.cs
Esta classe lida com a exibi��o do painel, regras do jogo, comandos de movimento, e a impress�o do mapa do terreno com a posi��o dos rob�s.

 #### Fun��es importantes:

 - ShowPannel( ): Exibe o painel inicial com o t�tulo e descri��o do jogo.
	
 - ShowRules( ): Exibe as regras do jogo.
	
 - PrintMap( ): Desenha o terreno com a posi��o dos rob�s.

 - MoveRobots( ): Atualiza as posi��es dos rob�s com base nos comandos inseridos.
 
 - ExecuteCommand(): Processa os comandos de movimento (E, D, M).

### 3 - KindsOfValidation.cs
A classe de valida��o lida com a verifica��o da entrada do usu�rio e a manuten��o da integridade do estado do jogo.

 ### Valida��es importantes:

- Coordenadas do rob� e dire��o inicial.

- Comandos v�lidos para o rob�.

- Detec��o de colis�o entre os rob�s.

### 4 - GameLogic.cs
Esta classe gerencia a l�gica do jogo, incluindo a movimenta��o dos rob�s, execu��o de comandos e verifica��o de colis�es.

# Como Jogar
### Passos Iniciais

- Defina o terreno: O jogo come�a exibindo o tamanho do terreno. O tamanho do terreno pode ser escolhido na inicializa��o do jogo.

- Posicione os rob�s: O jogador deve inserir as coordenadas iniciais para cada rob�. As coordenadas devem estar no formato X, Y DIRE��O (exemplo: 0,0 N).

- Comandos de movimento: O jogador deve inserir uma sequ�ncia de comandos de movimento para guiar os rob�s pela �rea explorada. Os comandos poss�veis s�o:

- E: Gira o rob� 90� para a esquerda.

- D: Gira o rob� 90� para a direita.

- M: Move o rob� para a frente.

## Fases do Jogo
- Explora��o do Terreno: O jogador pode guiar os rob�s para explorar o terreno, utilizando os comandos.

- Colis�o: Se os rob�s colidirem, o jogo detecta o erro e pode finalizar a partida ou reiniciar.

- Rein�cio: Ap�s uma rodada, o jogo pergunta se o jogador deseja jogar novamente.

## Exemplo de Entrada
Coordenada inicial do rob�: 0,0 N

Comandos de movimento: MMMRM

## Exemplo de Mapa
O mapa de 10x10 pode ser visualizado, com a posi��o dos rob�s sendo representada pelos s�mbolos:

- '^' para o rob� apontando para o norte (Norte).

- 'v' para o rob� apontando para o sul (Sul).

-  '>' para o rob� apontando para o leste (Leste).

- '<' para o rob� apontando para o oeste (Oeste).

# Instru��es de Execu��o
### Requisitos

- .NET SDK vers�o 5 ou superior.

- Um editor de texto (Visual Studio, Visual Studio Code ou similar).

- Clonar o reposit�rio

- bash

# COMO JOGAR

- Clone o Reposit�rio
```
git clone https://github.com/xleonardoxmed/Rob-Tupiniquim.git
```
Navegue at� a pasta raiz da solu��o
```
cd Rob�Tupiniquim
```
Restaure as depend�ncias
```
dotnet restore
```
Navegue at� a pasta do projeto
```
cd Rob�Tupiniquim.ConsoleApp
```
Execute o projeto
```
dotnet run
```
# Se divirta explorando um novo planeta!!!