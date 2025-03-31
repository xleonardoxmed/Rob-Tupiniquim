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
                    {
                        KindOfValidation.notTheFirstTime = true;
                        KindOfValidation.AskValidCommandsAndKeep();
                        GameVisual.MoveRobots();
                    }
                    
                    if(GameVisual.ExplodeIFCollide())
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
                Console.WriteLine("\n===========================================================================");
                Console.Write("Deseja jogar de novo e explorar uma nova áera? (S/N): ");
                Console.WriteLine("\n===========================================================================");
                string toContinue = Console.ReadLine()!.ToUpper();

                if (toContinue != "S")
                    break;
            }

        }
    }
}
