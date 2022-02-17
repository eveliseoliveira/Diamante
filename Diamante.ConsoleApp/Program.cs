using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho_diamante = 0;

            Console.WriteLine("Informe o tamanho do diamante de x:");
            tamanho_diamante = int.Parse(Console.ReadLine());

            int quantidade_espacos = (tamanho_diamante - 1) / 2;
            int quantidade_x = 1;
            int quantidade_linhas = (tamanho_diamante - 1) / 2;

            for (int linhas = 0; linhas < quantidade_linhas; linhas++)
            {
                for (int i = 0; i < quantidade_espacos; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < quantidade_x; i++)
                {
                    Console.Write("x");
                }
                quantidade_espacos--;
                quantidade_x += 2;
                Console.WriteLine();
            }
            for (int coluna = 0; coluna < tamanho_diamante; coluna++)
            {
                Console.Write("x");
            }

            quantidade_espacos++;
            quantidade_x -= 2;
            Console.WriteLine();

            for (int linhas = 0; linhas < quantidade_linhas; linhas++)
            {
                for (int i = 0; i < quantidade_espacos; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < quantidade_x; i++)
                {
                    Console.Write("x");
                }
                quantidade_espacos++;
                quantidade_x -= 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
