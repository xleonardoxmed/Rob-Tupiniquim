using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobôTupiniquim.ConsoleApp
{
    class KindOfValidation
    {
        public static bool notTheFirstTime = false;
        private static int Xcoordenate;
        private static int Ycoordenate;
        private static char direction;
        public static string[] Robot1LocationAndDirection;
        public static string[] Robot2LocationAndDirection;
        public static int area;
        public static int width;
        public static int height;
        private static char[] allChars;
        public static char[] robot1Commands;
        public static char[] robot2Commands;
        public static void AreaValidationAndDraw()
        {
            bool success;
            width = 0;
            height = 0;
            int answer = 0;
            string ask = "";

            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("Você recebeu permissão para usar DOIS ROBÔS de para sua aventura! Vamos lá!");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Escolha o a LARGURA e a ALTURA do terreno retangular que deseja explorar.");
            Console.WriteLine("---------------------------------------------------------------------------");

            for (int checks = 0; checks <= 1; checks++)
            {
                if (checks == 0)
                {
                    ask = "LARGURA";
                }
                else
                {
                    ask = "ALTURA";
                }
                do
                {
                    Console.Write($"\n                             {ask}: ");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out answer);

                    if (!success || answer <= 0)
                    {
                        Console.WriteLine("Erro! Somente números inteiros e positivos serão aceitos.");
                        Console.WriteLine("---------------------------------------------------------------------------");
                        continue;
                    }

                } while (!success || answer <= 0);

                if (checks == 0)
                    width = answer;
                else
                    height = answer;
            }
            area = width * height;
            Console.WriteLine($"\n                    A área escolhida é de: {area}m²");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("\n                       Exemplo ilustrativo:\n ");
            Console.WriteLine($"                              (X,Y)");
            Console.WriteLine($"                  (0,{height})  ------------  ({width}, {height})");
            Console.WriteLine("                         |            |");
            Console.WriteLine($"                         |            | {height}m");
            Console.WriteLine("                         |            |");
            Console.WriteLine($"                  (0,0)   ------------  ({width}, 0)");
            Console.WriteLine($"                               {width}m");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                 Digite qualquer tecla para continuar");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }

        public static void AskValidCommandsAndKeep()
        {
            String[] locationAndDirection;
            int robot;
            bool success = false;

            for (int checks = 0; checks <= 1; checks++)
            {
                if (checks == 0)
                {
                    robot = 1;
                }
                else
                {
                    robot = 2;
                }

                if (notTheFirstTime == false)
                {
                    do
                    {
                        Console.Write($"\nInsira a COORDENADA INICIAL do Robô #{robot} (X,Y) e a DIREÇÃO (N,S,L, O): ");
                        string entry = Console.ReadLine()!;
                        locationAndDirection = entry.Split(new char[] { ' ', ',', '(', ')', '.' }, StringSplitOptions.RemoveEmptyEntries);
                        //REMOVE TODOS OS CARACTERES INDESEJADOS E FILTRA O QUE É PEDIDO

                        if (locationAndDirection.Length != 3)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Erro! Insira comandos válidos (Positivos) separados por espaços. EX: (Número Número Letra).");
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Apenas números inteiros permitidos");
                            continue;
                        }

                      
                        success =
                            int.TryParse(locationAndDirection[0], out Xcoordenate) &&
                            int.TryParse(locationAndDirection[1], out Ycoordenate) &&
                            locationAndDirection[2].Length == 1 &&
                            "NSLO".Contains(Char.ToUpper(locationAndDirection[2][0]));

                        if (!success || Xcoordenate < 0 || Ycoordenate < 0)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Erro! Insira comandos válidos (Positivos) separados por espaços. EX: (Número Número Letra).");
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Apenas números inteiros permitidos");
                            continue;
                        }

                        else if (Xcoordenate > width || Ycoordenate > height)
                        {
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine($"Erro! Insira coordenadas (positivas) que existam dentro do terreno escolido: {width}:{height}");
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.WriteLine("Apenas números inteiros permitidos");
                            continue;
                        }

                        direction = Char.ToUpper(locationAndDirection[2][0]);
                        locationAndDirection[2] = direction.ToString();

                        if (robot == 1)
                            Robot1LocationAndDirection = locationAndDirection;

                        else
                            Robot2LocationAndDirection = locationAndDirection;

                    } while (!success || Xcoordenate < 0 || Ycoordenate < 0 || Xcoordenate > width || Ycoordenate > height);
                }

                do
                {
                    Console.Write($"\nInsira os MOVIMENTOS do Robô #{robot} (E, D M): ");

                    string allMovements = Console.ReadLine()!.ToUpper();
                    allChars = allMovements.Where(m => m != ' ' && m != '-' && m != ',' && m != '.').ToArray();
                    success = true;

                    for (int charChecks = 0; charChecks < allChars.Length; charChecks++)
                    {
                        if (allChars[charChecks] != 'E' && allChars[charChecks] != 'D' && allChars[charChecks] != 'M' || int.TryParse(allChars[charChecks].ToString(), out int _))
                        {
                            success = false;
                            break;
                        }
                        // '_' SERVE PARA VARIÁVEIS DESCARTÁVEIS // TryParse espera uma string, pra isso: ToString();           
                    }

                    if (!success)
                    {
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Erro! Apenas os movimentos 'E' (Esquerda), 'D' (Direita), e 'M' (Mover) são válidos.");
                        Console.WriteLine("---------------------------------------------------------------------------");
                        continue;
                    }

                    if (robot == 1)
                        robot1Commands = allChars;
                    else
                        robot2Commands = allChars;

                } while (!success);

            }


        }

    }
}
