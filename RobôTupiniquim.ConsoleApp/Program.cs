namespace RobôTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                GameVisual.ShowPannel();
                GameVisual.ShowRules();
                GameVisual.StartScreen();

                KindOfValidation.AreaValidationAndDraw();
                GameVisual.ShowPannel();
                KindOfValidation.AskValidCommandsAndKeep();
                GameVisual.MoveRobots();

                while (true)
                {                  
                    Console.WriteLine("\nDigite 'ENTER' para CONTINUAR EXPLORANDO |OU| 'X' para ENCERRAR EXPEDIÇÃO");
                    string newCommands = Console.ReadLine()!.ToUpper();

                    if (newCommands.Trim() == "X")
                        break;
                    else

                    KindOfValidation.notTheFirstTime = true;
                    KindOfValidation.AskValidCommandsAndKeep();
                    GameVisual.MoveRobots();
                }
                Console.WriteLine("\n===========================================================================");
                Console.Write("Deseja explorar uma nova áera? (S/N): ");
                Console.WriteLine("\n===========================================================================");
                string toContinue = Console.ReadLine()!.ToUpper();

                if (toContinue != "S")
                    break;
            }
        }
    }
}
