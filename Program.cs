using System;

namespace DesafioAvanade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coloque aqui os códigos dos desafios: Resover Algoritmo e Solucao Problemas Essenciais em C#.   
            double numero, cont = 0, totaldois, totaltres;
            Console.Write("Digite um número Inteiro positivo: "); //Não colocar no desafio.
            numero = double.Parse(Console.ReadLine());
            if (0 < numero && numero < 1000)
            {
                for (double i = 1; i <= numero; i++)
                {
                    totaldois = Math.Pow(i, 2);
                    totaltres = Math.Pow(i, 3);
                    cont++;
                    Console.WriteLine($"{i} {totaldois} {totaltres}");
                    //Console.WriteLine($"Cont: {i} {totaldois} {totaltres}");                    
                }
            }
            else
            {
                Console.WriteLine("Número ou caractere inválido!!!");
            }            
            Console.ReadKey();
        }
    }
}


