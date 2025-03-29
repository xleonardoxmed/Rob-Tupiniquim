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
        public static int chars;
        public static int Xcoordenate;
        public static int Ycoordenate;
        public static char direction;
        public static int area;
        public static char[] allChars;
        public static void AreaValidationAndDraw()
        {
            bool success;
            int width = 0;
            int heigth = 0;
            int answer = 0;
            string ask = "";

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
                    heigth = answer;
            }
            area = width * heigth;
            Console.WriteLine($"\n                    A área escolhida é de: {area}m²");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("\n                       Exemplo ilustrativo:\n ");
            Console.WriteLine($"                              (X,Y)");
            Console.WriteLine($"                  (0,{heigth})  ------------  ({width}, {heigth})");
            Console.WriteLine("                         |            |");
            Console.WriteLine($"                         |            | {heigth}m");
            Console.WriteLine("                         |            |");
            Console.WriteLine($"                  (0,0)   ------------  ({width}, 0)");
            Console.WriteLine($"                               {width}m");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                 Digite qualquer tecla para continuar");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }

        public static void AskValidCommands()
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
                do
                {
                    Console.Write($"\nInsira a COORDENADA INICIAL do Robô #{robot} (X,Y) e a DIREÇÃO (N,S,L, O): ");
                    string entry = Console.ReadLine()!;
                    locationAndDirection = entry.Split(new char[] { ' ', ',', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
                    //REMOVE TODOS OS CARACTERES INDESEJADOS E FILTRA O QUE É PEDIDO

                    if (locationAndDirection.Length != 3)
                    {
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Erro! Insira comandos válidos separados por espaços. EX: (Número Número Letra).");
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Apenas números inteiros permitidos");
                        Console.WriteLine("---------------------------------------------------------------------------");
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
                        Console.WriteLine("Erro! Insira comandos válidos separados por espaços (SEM VÍRGULA). EX: (Número Número Letra).");
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.WriteLine("Apenas números inteiros permitidos");
                        continue;
                    }

                    direction = Char.ToUpper(locationAndDirection[2][0]);

                } while (!success || Xcoordenate < 0 || Ycoordenate < 0);

                do
                {
                    Console.Write($"\nInsira os MOVIMENTOS do Robô #{robot} (E, D M): ");

                    string allMovements = Console.ReadLine()!.ToUpper();
                    allChars = allMovements.Where(m => m != ' ' && m != '-' && m != ',').ToArray();


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
                        Console.WriteLine("Apenas números inteiros permitidos");
                        continue;
                    }

                } while (!success);

            }


        }

    }
}
