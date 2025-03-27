﻿namespace RobôTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================ROBÔ TUPINIQUIM=====================================");
                Console.WriteLine("A exploração do cosmos é uma viagem para autodescoberta.");
                Console.WriteLine("===========================================================================");
                Console.WriteLine("Escolha o a LARGURA e a ALTURA do terreno retangular que deseja explorar: ");
                Console.WriteLine("---------------------------------------------------------------------------");

                KindOfValidation.AreaValidation();
                
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
