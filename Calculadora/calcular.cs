using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class calcular
    {
        public calcular()
        {
        }

            float n1 = 0;
            float n2 = 0;
            float result = 0; 
        public float somar()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("\nMuito bem, você escolheu o método somar. Vamos lá!\n");
                    Console.WriteLine("Escolha o primeiro numero que irá ser somado: \n");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escolha outro numero que irá ser somado: \n");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = n1 + n2;
                    Console.Write("A soma dos numeros {0} + {1} é {2}\n", n1, n2, result);
                    

                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine("Entrada inválida. \nPor favor digite um entrada válida.\n");
                    Console.WriteLine(ForEx);
                }

            Console.WriteLine("você deseja continuar ? ");
            string saida = Console.ReadLine().ToLower();
            if (saida == "s")
            {
                break;
            }
                else if (saida == "n")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("nao entendi. Vou rodar novamente...");
                    }
                Console.Clear();

            }  



            return result; 
        }
        

        public float subtrair()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMuito bem, você escolheu o método subtrair. Vamos lá!\n");
                    Console.WriteLine("Escolha o primeiro numero que irá ser subtraido: \n");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escolha outro numero que irá ser subtraido: \n");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = n1 - n2;
                    Console.Write("A subtração dos numeros {0} - {1} é {2}\n", n1, n2, result);


                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine("Entrada inválida. \nPor favor digite um entrada válida.\n");
                    Console.WriteLine(ForEx.Message);
                }

                Console.WriteLine("você deseja continuar ? S ou N\n");
                string saida = Console.ReadLine().ToLower();
                Console.Clear();
                if (saida == "s")
                {
                    break;
                }
                else if (saida == "n")
                {
                    Console.WriteLine(); 
                } else
                {
                    Console.WriteLine("nao entendi. Vou rodar novamente...");
                }

            }
            return (int)(double)result;
        }

        public float multiplicar()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Muito bem, você escolheu método multiplicar. Vamos lá\n");
                    Console.WriteLine("Escolha um numero para ser multiplicado: \n");
                    n1 = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("Escolha outro numero para ser multiplicado: \n");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = n1 * n2; 
                    Console.Write("A mutiplicação {0} x {1} é {2}", n1, n2, result);

                }
                catch (FormatException ForEx)
                {
                    Console.WriteLine("entrada inválida. \nPor favor digite uma entrada válida.\n");
                    Console.WriteLine(ForEx.Message);
                }

                Console.WriteLine("\nDeseja continuar ? S ou N\n");
                string sair = Console.ReadLine().ToLower();
                Console.Clear();
                if (sair != "s")
                {
                    break; 
                } else if (sair == "n")
                {
                    Console.WriteLine(); 
                } else
                {
                    Console.WriteLine("nao entendi. Vou rodar novamente...");
                }

            }
            return (int)((float)n1 * n2);
        }

        public float dividir()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Muito bem, você escolheu o método dividir.\nVamos lá\n");
                    Console.WriteLine("Escolha um numero para ser dividido: \n"); 
                    n1 = (int)Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escolha outro numero para ser dividido: \n");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    result = (float)n1 / n2;
                    Console.Write("A divisao do numero {0} / {1} é {2}\n", n1, n2, result); 

                } catch (FormatException Forex)
                {
                    Console.WriteLine("Entrada inválida. \nPor favor digite uma entrada válida\n");
                    Console.WriteLine(Forex.Message);
                } catch (DivideByZeroException Dex)
                {
                    Console.WriteLine("Tentativa de divisão por 0.\n Por favor digite outro numero\n"); 
                    Console.WriteLine(Dex.Message);
                }

                Console.WriteLine("\nDeseja continuar ? S ou N"); 
                string sair = Console.ReadLine().ToLower();
                Console.Clear();
                if (sair == "s")
                {
                    break; 
                } else if (sair == "n")
                {
                    Console.WriteLine();
                } else
                {
                    Console.WriteLine("nao entendi. Vou rodar novamente...");
                }
            }           
            return result;
        }

        public float exponenciacao()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("muito bem, você escolheu o método exponenciação.\n Vamos lá\n");
                    Console.WriteLine("Esclha a base do numero a ser exponenciado: \n");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escolha o expoente da base: \n");
                    n2 = (int)Convert.ToInt32(Console.ReadLine());
                    result = n1;
                    for (int i = 1; i <= n2-1; i++)
                    {
                        result *= n1;
                    }
                    Console.Write("o resultado do numero {0} elevado ao expoente {1} é {2}\n", n1, n2, result);

                } catch (FormatException ex)
                {
                    Console.WriteLine("Entrada inválida.\n Por favor digite ma entrada válida.");
                    Console.WriteLine(ex.Message); 
                }

                Console.WriteLine("Deseja continuar ? S ou N");
                string sair = Console.ReadLine().ToLower();
                Console.Clear();
                if (sair == "s")
                {
                    break;
                }
                else if (sair == "n")
                {
                    Console.WriteLine("");
                } else
                {
                    Console.WriteLine("nao entendi. vou rodar novamente..."); 
                }
                



            }
        
            
            
            
            return 0;
        }
        
    }
    
}
