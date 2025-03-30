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
                GameVisual.PrintMap(GameVisual.cartesian);

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
