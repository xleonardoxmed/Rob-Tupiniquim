using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobôTupiniquim.ConsoleApp
{
    class GameVisual
    {
        public static void ShowPannel()
        {
            Console.WriteLine("==========================ROBÔ TUPINIQUIM==================================");
            Console.WriteLine("         A exploração do cosmos é uma viagem para autodescoberta.");
            Console.WriteLine("===========================================================================");
        }
        public static void ShowRules()
        {          
            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("Deseja ler as regras do jogo? (Recomendado para a primeira jogada)");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Digite 'S' para ler || Digite 'N' para pular");
            string rules = Console.ReadLine()!.ToUpper();
            if (rules == "S")
            {
                Console.Clear();
                ShowPannel();
                Console.WriteLine("\n---------------------------------------------------------------------------");
                Console.WriteLine("                 O jogo funcionará da seguinte maneira:");
                Console.WriteLine("         Seus robôs estarão dentro do terreno que você escolheu.");
                Console.WriteLine("         Para que eles possam explorá-lo, você terá que comandar.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("     Serão solicitados para você: Uma coordenada inicial (X,Y) para cada robô,");
                Console.WriteLine("\njuntamente de uma direção para qual cada robô deve estar apontando (N,S,L,O)");
                Console.WriteLine("                                 ↓");
                Console.WriteLine("                      (NORTE, SUL, LESTE E OESTE)");
                Console.WriteLine("\nE em seguida voce terá a opção de digitar os comandos: E, D ou M");
                Console.WriteLine("                                 ↓");
                Console.WriteLine("               (E => Girar o robô 90° para a ESQUERDA)");
                Console.WriteLine("               (D => Girar o robô 90° para a DIREITA)");
                Console.WriteLine("               (M => Mover o robô para frente (Na direção em que estiver apontando)");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("     Exemplo de entrada: 1 2 N => Entende-se como Posição = (1,2) e Direção = Norte");
                Console.WriteLine("     Exemplo de movimento: EEMMMD => Entende-se girar em 90° duas vezes,");
                Console.WriteLine("     mover para frente três vezes e girar para a direita.");
                Console.WriteLine("     \nIsso resultará numa nova coordenada para cada robô após seus comandos.");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("                 Digite qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                ShowPannel();
            }
        }
    }
}
