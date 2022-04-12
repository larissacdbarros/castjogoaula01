using System;

namespace JogoAula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int i = 0;
            while (continuar)
            {
                int input = new Random().Next(1, 5);

                Console.WriteLine("Chute o número sorteado pelo computador entre 1 e 5");
                int numUsuario = int.Parse(Console.ReadLine());
                
                i++;

                if (input == numUsuario)
                {
                    Console.Clear();
                    Console.WriteLine("Número sorteado pelo computador:" + input + "\n");
                    Console.WriteLine($"Parabéns você acerto com {i} tentativas");
                    break;
                }
                else if (numUsuario >= 1 && numUsuario <= 5)
                {
                    Console.Clear();
                    Console.WriteLine("Errooou");
                    Console.WriteLine("Número sorteado pelo computador:" + input);
                    Console.WriteLine("Tente novamente\n");
               
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Numero colocado pelo usúario não está entre 1  e 5 \n");

                }

                

            }
        }
    }
}
