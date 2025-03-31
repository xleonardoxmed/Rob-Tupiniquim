using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobôTupiniquim.ConsoleApp
{
    class GameLogic
    {
        public static void InitializeGame()
        {
            KindOfValidation.AreaValidationAndDraw();
            GameVisual.ShowPannel();
            KindOfValidation.AskValidCommandsAndKeep();
            GameVisual.MoveRobots();
        }

        public static void ExploreArea()
        {
            while (true)
            {
                Console.WriteLine("\nDigite 'ENTER' para CONTINUAR EXPLORANDO |OU| 'X' para ENCERRAR EXPEDIÇÃO");
                string newCommands = Console.ReadLine()!.ToUpper();

                if (newCommands.Trim() == "X")
                    break;

                // EXPEDIÇÃO CONTINUA
                KindOfValidation.notTheFirstTime = true;
                KindOfValidation.AskValidCommandsAndKeep();
                GameVisual.MoveRobots();

                // CHECAGEM DE COLISÃO
                if (GameVisual.ExplodeIFCollide())
                {
                    Console.Clear();
                    GameVisual.ShowPannel();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("BOOOOM!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("Seus robôs bateram e explodiram :(");
                    break;
                }
            }
        }

    }
}
