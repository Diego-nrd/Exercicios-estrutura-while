using System;

namespace Exercicios_estrutura_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercicio 01 fazer um while que repida uma leitura até que a senha seja valida//
            Console.Write("Digite a Senha: ");

            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida!");
                Console.Write("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
            */

            /*
            //Exercicio 02 um programa que ler as coordenadas de uma quantidade interteminada o algoritimo sera encerrado quando uma das ocorrecia for 0//
            Console.Write("Digite as Coordenadas(X, Y): ");

            string[] n = Console.ReadLine().Split(' ');

            int x = int.Parse(n[0]);
            int y = int.Parse(n[1]);

            while ( x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                    Console.Write("Digite as Coordenadas: ");
                
                }else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                    Console.Write("Digite as Coordenadas: ");
                  
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                    Console.Write("Digite as Coordenadas: ");
                   
                }
                else
                {
                    Console.WriteLine("Quarto");
                    Console.Write("Digite as Coordenadas: ");
                   
                }
                n = Console.ReadLine().Split(' ');

                x = int.Parse(n[0]);
                y = int.Parse(n[1]);
            }
            */

            //Exercicio 03 fazer um programa com 3 opçoes de combustivel acol gasolina e disel, e só sera encerrado se digitar o 4
            Console.Write("1.Álcool\n2.Gasolina\n3.Disel\n4.Fim\nDigite uma das Opções: ");

            int opcoes = int.Parse(Console.ReadLine());
            int a = 0,g = 0,d = 0;

            while (opcoes != 4)
            {
                if (opcoes == 1)
                {
                    a = ++a;
                
                } else if (opcoes == 2)
                {
                    g = ++g;
                }
                else if (opcoes == 3)
                {
                    d = ++d;
                }

                Console.Write("Digite uma das Opções: ");
                opcoes = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado!\n" + "Álcool: " + a + "\n" + "Gasolina: " + g + "\n" + "Disel: " + d);
        }
    }
}
