using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobôTupiniquim.ConsoleApp
{
    class KindOfValidation
    {
        public static int area;
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
            Console.WriteLine("\n                        Exemplo ilustrativo: ");
            Console.WriteLine("                           ------------");
            Console.WriteLine("                          |            |");
            Console.WriteLine($"                          |            | {heigth}m");
            Console.WriteLine("                          |            |");
            Console.WriteLine("                           ------------");
            Console.WriteLine($"                               {width}m");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("                 Digite qualquer tecla para continuar");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public static void ComandValidation()
        {

        }

    }
}
