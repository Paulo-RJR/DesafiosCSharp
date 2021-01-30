using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAvanade
{
    class DesafioResoverAlgoritmo
    {
        /*DIO - Avanade - Desafio Resolver Algoritmos.
        
        Desafio - 1/7:        
            //Minha versão - Falta funcionar a segunda resposta.
            //Console.Write("Infome o número de voltas na pista: ");
            //var numVoltas = int.Parse(Console.ReadLine());
            //Console.Write("\nInforme o número de placas na pista: ");
            //var numPlacas = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Voltas: {numVoltas} - Placas: {numPlacas}");
            //int resp = numPlacas / numVoltas;
            //Console.WriteLine($"Resposta: {resp}");           
            //for (int i = 1; i < 10; i++){               
            //int percorre = (resp * i) + 1; // Fórmula correta para 3 e 17
            //Console.Write($" {percorre} "); 
            //Console.WriteLine($"Percurso: {percorre}");
            //i += 1;
            //}
        
        //Desafio - 1 / 7: Versão do curso (Funciona). 
            String[] corrida = Console.ReadLine().Split(" ");
            int numvolta, numplaca; 
            double total, acumulado;
            int.TryParse(corrida[0], out numvolta);
            int.TryParse(corrida[1], out numplaca);            
            while (!(numvolta >= 1 && numplaca <= 104))
            {
                corrida = Console.ReadLine().Split(" ");
                int.TryParse(corrida[0], out numvolta);
                int.TryParse(corrida[1], out numplaca);
            }
            total = numvolta * numplaca;
            for (double taxa = 0.1; taxa <= 0.9; taxa += 0.1)
            {
                acumulado = total * taxa;
                Console.Write(Math.Ceiling(acumulado) + " ");
            }
           
        Desafio - 2/7:

        Desafio - 3/7: Funciona
           string[] line = Console.ReadLine().Split(" ");
           int npessoa = int.Parse(line[0]);
           int dtproxima = int.Parse(line[1]);
           string vazia = "";
           int quantidade = 0;
           bool achou = false;
           for (int dt=0; dt < dtproxima; dt++)
           {
            quantidade = 0;
            string[] dados = Console.ReadLine().Split(" ");
            vazia = dados[0];
            for (int pcomparece=1; pcomparece < npessoa+1; pcomparece++)
            {
              quantidade += int.Parse( dados[pcomparece] );
            } //for p
            achou = ( quantidade == npessoa);
            if (achou) 
            { 
                break; 
            }
           } //for dt
           if (achou) 
           { 
            Console.Write(vazia);
           }
           else
           { 
            Console.Write("Pizza antes de FdA");
           }

        Desafio - 4/7: Funciona
            int tempo, hora, minuto, segundo; //Com entrada de dados feita pelo usuário.
            Console.Write("Digite o valor em Segundos: ");
            tempo = int.Parse(Console.ReadLine());
            hora = tempo / 3600;
            minuto = tempo % 3600 / 60;
            segundo = tempo % 60;
            Console.WriteLine($"{hora}:{minuto}:{segundo}");

        Desafio - 5/7:
            Console.Write("Informe a sua idade em dias: ");
            var idadeEmDias = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var anos = 1 * (idadeEmDias / 365); // Implemente aqui o calculo dos anos
            var meses = (idadeEmDias % 365) / 30; // Implemente aqui o calculo dos meses 
            var dias = ((idadeEmDias % 365) % 30) * 1; // Implemente aqui o calculo dos dias
            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");

        Desafio - 6/7: Funciona
            int minutoTotal, minPresenteA, minPresenteB, presenteAB;
            Console.Write("Informe o tempo restante para fabricar os presentes: "):
            minutoTotal = int.Parse(Console.ReadLine());
            Console.Write("Informe o tempo para fabricar os presentes A e B: "):
            String[] minutoPresenteAB = Console.ReadLine().Split(" ");            
            int.TryParse(minutoPresenteAB[0], out minPresenteA);
            int.TryParse(minutoPresenteAB[1], out minPresenteB);
            presenteAB = minPresenteA + minPresenteB ;
            if(minutoTotal >= presenteAB) 
                Console.WriteLine("\nFarei hoje!");

            else 
                Console.WriteLine("\nDeixa para amanha!"); // Tenho de retirar o acento da palavra amanhã para o programa rodar no desafio.

        Desafio - 7/7: Funciona
        int qtdTeste = int.Parse(Console.ReadLine());


            for (int i = 0; i < qtdTeste; i++)
            {

                string placa = Console.ReadLine();

                if (EstaNoPadrao(placa))
                {

                    Console.WriteLine(Rodizio(placa));

                }

                else
                {

                    Console.WriteLine("FALHA");

                }
            }
         }
        public static bool EstaNoPadrao (string placa)
        {

            bool placaOk = false;

            if (placa.Length == 8)
            {

                placaOk = (placa[3] == '-') &&

                      (Char.IsDigit(placa[4])) &&

                      (Char.IsDigit(placa[5])) &&

                      (Char.IsDigit(placa[6])) &&

                      (Char.IsDigit(placa[7])) &&

                      (Char.IsLetter(placa[0])) &&

                      (Char.IsLetter(placa[1])) &&

                      (Char.IsLetter(placa[2])) &&

                      (Char.IsUpper(placa[0])) &&

                      (Char.IsUpper(placa[1])) &&

                      (Char.IsUpper(placa[2]));

            }

            return placaOk;

        }



        public static string Rodizio (string placa)
        {

            string aux = "";

            char digitoFinal = placa[placa.Length - 1];

            switch (digitoFinal)
            {

                case '1': aux = "SEGUNDA"; break;

                case '2': aux = "SEGUNDA"; break;

                case '3': aux = "TERCA"; break;

                case '4': aux = "TERCA"; break;

                case '5': aux = "QUARTA"; break;

                case '6': aux = "QUARTA"; break;

                case '7': aux = "QUINTA"; break;

                case '8': aux = "QUINTA"; break;

                case '9': aux = "SEXTA"; break;

                case '0': aux = "SEXTA"; break;

                default: aux = "FALHA"; break;

            }

            return aux;
        Console.Clear();
        */

    }
}
