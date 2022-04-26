using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProvaPTPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] gabarito = new int[5], respostas = new int[5];
            int matricula, acertos = 0;

            for (int i = 0; i < 5; i++)
            {
                gabarito[i] = random.Next(1, 4);
                Console.WriteLine("Gabarito: " + gabarito[i] + "\t");
            }
            // Input da Primeira Matricula
            Console.WriteLine("Digite seu numero de matricula: ");
            matricula = int.Parse(Console.ReadLine());

            while (matricula != 999999)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Questão nº " + i + ": ");

                    respostas[i] = int.Parse(Console.ReadLine());

                    if (respostas[i] == gabarito[i])
                    {
                        acertos++;
                    }
                    Console.WriteLine("Resposta: " + respostas[i] + "\n");
                }

                Console.WriteLine("Numero da Matricula: " + matricula);

                if (acertos >= 3)
                {
                    Console.WriteLine("Aprovado \n");
                }
                Console.WriteLine("Quantidade de acerto: " + acertos + "\n");
                Console.WriteLine("Digite seu numero de matricula: ");
                matricula = int.Parse(Console.ReadLine());

            }
        }
    }
}
