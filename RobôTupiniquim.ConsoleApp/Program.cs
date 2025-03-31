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
                GameLogic.InitializeGame();
                GameLogic.ExploreArea();
                if (!GameVisual.AskToPlayAgain())
                    break;
            }

        }
    }
}
