using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora 
{
    internal class menu : calcular 
    {
        calcular calc = new calcular();
        int escolha;
        int n1 = 0;
        int n2 = 0;
        int result = 0;
        public void meuMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("             MENU PINCIPAL                  ");
            Console.WriteLine("   Escolha uma dentre as operações abaixo   ");
            Console.WriteLine("   1 - somar                                ");
            Console.WriteLine("   2 - subtrair                             ");
            Console.WriteLine("   3 - multiplicar                          ");
            Console.WriteLine("   4 - dividir                              ");
            Console.WriteLine("   5 - Exponenciação                        ");
            Console.WriteLine("   6 - Fechar o programa                    ");
            Console.WriteLine("--------------------------------------------");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    calc.somar();
                    Console.Clear();
                    meuMenu();
                    break;

                case 2:
                    calc.subtrair();
                    Console.Clear();
                    meuMenu();
                    break; 

                case 3:
                    calc.multiplicar();
                    Console.Clear();
                    meuMenu();
                    break;

                case 4:
                    calc.dividir();
                    Console.Clear();
                    meuMenu(); 
                    break;

                case 5:
                    calc.exponenciacao();
                    Console.Clear();
                    meuMenu(); 
                    break;

                case 6:
                    Console.WriteLine("Obrigado pela visita. Volte sempre...");
                    break;
            }



        }
    }
}
