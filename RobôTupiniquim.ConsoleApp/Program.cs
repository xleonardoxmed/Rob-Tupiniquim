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
                Console.WriteLine("\n---------------------------------------------------------------------------");
                Console.WriteLine("Escolha o a LARGURA e a ALTURA do terreno retangular que deseja explorar.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Você recebeu permissão para usar DOIS ROBÔS de para sua aventura! Vamos lá!");
                Console.WriteLine("---------------------------------------------------------------------------");

                KindOfValidation.AreaValidationAndDraw();
                GameVisual.ShowPannel();
                GameVisual.ShowRules();
                GameVisual.FadingStartButton();

                /*for (int robot = 1; robot <= 3; robot++)
                {

                    Console.WriteLine($"Insira a coordenada inicial do Robô #{robot} e a direção: ");

                }
                */

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
