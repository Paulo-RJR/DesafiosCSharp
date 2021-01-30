using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAvanade
{
    class SolucaoProblemaEssencialC
    {
        //Desafio 1: Funciona.
        /*double numero, cont = 0, totaldois, totaltres;
        Console.Write("Digite um número Inteiro positivo: "); //Não colocar no desafio.
            numero = double.Parse(Console.ReadLine());            
            if(0 < numero && numero< 1000) 
            {
                for(double i = 1; i <= numero; i++) 
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
        
        Desafio 2: Funciona.
        int quantidadeEntradas = 3;
            while (quantidadeEntradas > 0)
            {
                var numeroQuantidade = Int32.Parse(Console.ReadLine());
                if (numeroQuantidade >= 1 && numeroQuantidade <= 500)
                {
                    string[] tartarugas = Console.ReadLine().Split(" ");
                    var maiorVelocidade = Int32.Parse(tartarugas[0]);

                    for (int i = 1; i < numeroQuantidade; i++)
                    {
                        var tartaruga = Int32.Parse(tartarugas[i]);
                        if (tartaruga > maiorVelocidade)
                        {
                            maiorVelocidade = tartaruga;
                        }
                    }

                    if (maiorVelocidade < 10)
                    {
                        Console.WriteLine(1);
                    }
                    else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
                    {
                        Console.WriteLine(2);
                    }
                    else if (maiorVelocidade >= 20)
                    {
                        Console.WriteLine(3);
                    }
                    quantidadeEntradas--;
                }
                else
                {
                    Console.WriteLine("Digite um número inteiro entre 1 e 500!");
                }
            }
            Console.ReadKey();

        
        //Desafio 3: Funciona.
            int valormaior = int.Parse(Console.ReadLine());
            int valor = int.Parse(Console.ReadLine());
            int cont = 0, somaTotal;
            bool verifica = true;
            List<int> lista = new List<int>();
            while (verifica)
            {
                if (valor <= valormaior)                
                    valor = int.Parse(Console.ReadLine()); 
                
                else                
                    verifica = false;               
            }

            do
            {
                cont++;
                lista.Add(valormaior);
                valormaior += 1;
                somaTotal = lista.Sum(x => Convert.ToInt32(x));
            } while (somaTotal < valor);

            Console.WriteLine(cont);
            Console.ReadKey();  
        
        Desafio 4: Funciona.
        double notaA = double.Parse(Console.ReadLine());
        while (notaA < 0 || notaA > 10) 
        {
        Console.WriteLine("nota invalida");
        notaA = double.Parse(Console.ReadLine());
        }

        double notaB = double.Parse(Console.ReadLine());
        while (notaB < 0 || notaB > 10) 
        {
        Console.WriteLine("nota invalida");
        notaB = double.Parse(Console.ReadLine());
        }

        var media = (notaA + notaB)/2;
        Console.Write($"media = {Math.Round(media,2)} "); // O comando Math.Round(media,2), faz com que o resultado mostre duas casas após o ponto.
        Console.ReadKey();
        
        Desafio 5: Funciona.
            string joiaAtual = Console.ReadLine();
            List<string> joias = new List<string> { };
            while (joiaAtual != null)
            {
                joias.Add(joiaAtual);
                joiaAtual = Console.ReadLine();
            }
            Console.WriteLine(joias.Distinct().Count());
            Console.ReadKey();
         */
    }
}
