using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RobôTupiniquim.ConsoleApp
{
    class GameVisual
    {
        public static char[,] cartesian;
        public static void ShowPannel()
        {
            Console.WriteLine("==========================ROBÔ TUPINIQUIM==================================");
            Console.WriteLine("         A exploração do cosmos é uma viagem para autodescoberta.");
            Console.WriteLine("===========================================================================");
        }
        public static void ShowRules()
        {

            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("Digite 'S' para LER AS REGRAS do jogo|| Aperte 'ENTER' para NOVO JOGO");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                (Recomendado para a primeira jogada)");


            string rules = Console.ReadLine()!.ToUpper();
            if (rules == "S")
            {
                Console.Clear();
                ShowPannel();
                Console.WriteLine("\n---------------------------------------------------------------------------");
                Console.WriteLine("                 O jogo funcionará da seguinte maneira:");
                Console.WriteLine("         Seus robôs estarão dentro do terreno que você escolheu.");
                Console.WriteLine("         Para que eles possam explorá-lo, você terá que comandar.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("     Serão solicitados para você: Uma coordenada inicial (X,Y) para cada robô,");
                Console.WriteLine("\njuntamente de uma direção para qual cada robô deve estar apontando (N,S,L,O)");
                Console.WriteLine("                                 ↓");
                Console.WriteLine("                      (NORTE, SUL, LESTE E OESTE)");
                Console.WriteLine("\nE em seguida voce terá a opção de digitar os comandos: E, D ou M");
                Console.WriteLine("                                 ↓");
                Console.WriteLine("               (E => Girar o robô 90° para a ESQUERDA)");
                Console.WriteLine("               (D => Girar o robô 90° para a DIREITA)");
                Console.WriteLine("               (M => Mover o robô para frente (Na direção em que estiver apontando)");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("     Exemplo de entrada: 1 2 N => Entende-se como Posição = (1,2) e Direção = Norte");
                Console.WriteLine("     Exemplo de movimento: EEMMMD => Entende-se girar em 90°para a esquerda duas vezes,");
                Console.WriteLine("     mover para frente três vezes e girar para a direita.");
                Console.WriteLine("     \nIsso resultará numa nova coordenada para cada robô após seus comandos.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("                 Digite qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                ShowPannel();
            }
            else
            {
                Console.Clear();
                ShowPannel();
            }

        }
        public static void StartScreen()
        {
            string startButton = "Pressione Qualquer Tecla para Jogar";
            int duration = 600;
            bool startGame = false;

            while (!startGame)
            {
                startGame = CheckKey(startGame);

                Console.Clear();
                int consoleWidth = Console.WindowWidth;
                int consoleHeight = Console.WindowHeight;
                int Xposition = (consoleWidth - startButton.Length) / 2; // Centro
                int Yposition = consoleHeight - 3; // Fundo, 3 pixels acima
                Console.SetCursorPosition(Xposition, Yposition); // Inicia o cursor onde o startButton deve ficar           
                Console.Write(startButton); // efeito de sumir/reaparecer
                Thread.Sleep(duration);
                Console.Clear();

                startGame = CheckKey(startGame);
            }
            ShowPannel();
        }
        public static bool CheckKey(bool startGame)
        {
            if (Console.KeyAvailable)
            {
                Console.ReadKey(true);
                startGame = true;
            }
            return startGame;
        }

        public static void MoveRobots()
        {
            int cartesianWidth = KindOfValidation.width;
            int cartesianHeight = KindOfValidation.height;

            char[,] cartesian = new char[cartesianHeight, cartesianWidth];
            //plano bidimensional Y:X

            for (int YspaceFiller = 0; YspaceFiller < cartesianHeight; YspaceFiller++)
                for (int XspaceFiller = 0; XspaceFiller < cartesianWidth; XspaceFiller++)
                    cartesian[YspaceFiller, XspaceFiller] = '.';

            int Xrobot1 = int.Parse(KindOfValidation.Robot1LocationAndDirection[0]);
            int Yrobot1 = int.Parse(KindOfValidation.Robot1LocationAndDirection[1]);
            char DirectionRobot1 = KindOfValidation.Robot1LocationAndDirection[2][0];

            int Xrobot2 = int.Parse(KindOfValidation.Robot2LocationAndDirection[0]);
            int Yrobot2 = int.Parse(KindOfValidation.Robot2LocationAndDirection[1]);
            char DirectionRobot2 = KindOfValidation.Robot2LocationAndDirection[2][0];

            //conversões

            cartesian[Yrobot1, Xrobot1] = '1';
            cartesian[Yrobot2, Xrobot2] = '2';

            PrintMap(cartesian);
            //robô 1
            foreach (char command in KindOfValidation.robot1Commands)
                ExecuteCommand(ref Xrobot1, ref Yrobot1, ref DirectionRobot1, command, cartesianWidth, cartesianHeight);
            //robô 2
            foreach (char command in KindOfValidation.robot2Commands)
                ExecuteCommand(ref Xrobot2, ref Yrobot2, ref DirectionRobot2, command, cartesianWidth, cartesianHeight);

            cartesian[Yrobot1, Xrobot1] = '1';
            cartesian[Yrobot2, Xrobot2] = '2';

            PrintMap(cartesian);
        }
        public static void PrintMap(char[,] cartesian)
        {
          
            Console.Clear();

            for (int counter = 0; counter < cartesian.GetLength(0); counter++) //linhas
            {
                for (int counter2 = 0; counter2 < cartesian.GetLength(1); counter2++) // colunas
                {
                    Console.Write(cartesian[counter, counter2] + " "); // impressão     
                }
                Console.WriteLine(); // pula
            }

        }

        public static void ExecuteCommand(ref int X, ref int Y, ref char direction, char command, int width, int height)
        {
            switch (command)
            {
                case 'E':
                    direction = TurnLeft(direction);
                    break;
                
                case 'D':
                    direction = TurnRight(direction);
                    break;
                
                case 'M':
                    MoveForward(ref X, ref Y, direction, width, height);
                    break;

                default:

                    break;
            }

        }
        public static char TurnLeft(char currentDirection)
        {
            switch (currentDirection)
            {
                case 'N': return 'O'; // Norte -esquerda- Oeste
                case 'O': return 'S'; // Oeste -esquerda- Sul
                case 'S': return 'L'; // Sul -esquerda- Leste
                case 'L': return 'N'; // Leste -esquerda- Norte
                default: return currentDirection;
            }
        }
        public static char TurnRight(char currentDirection)
        {
            switch (currentDirection)
            {
                case 'N': return 'L'; // Norte -direita- Leste
                case 'O': return 'N'; // Oeste -direita- Norte
                case 'S': return 'O'; // Sul -direita- Oeste
                case 'L': return 'S'; // Leste -direita- Sul
                default: return currentDirection;
            }
        }
        public static void MoveForward(ref int X, ref int Y, char direction, int width, int height)
        {
            switch (direction)
            {
                case 'N': if (Y < height - 1) Y++; break; 
                    // CIMA
                case 'S': if (Y > 0) Y--; break; 
                    // BAIXO
                case 'L': if (X < width - 1) X++; break;
                    // DIREITA
                case 'O': if (X > 0) X--; break;
                    // ESQUERDA
            }
        }

    }
}