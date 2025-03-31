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
                KindsOfValidation.AreaValidation(); 
                GameVisual.DrawAreaExample(); 
                GameLogic.InitializeGame(); 
                GameLogic.ExploreArea(); 
                if (!GameVisual.AskToPlayAgain()) 
                    break;
            }

        }
    }
}
