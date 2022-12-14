namespace ProvaDeMatematica
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;
    using System.Text;
    using System.Threading.Tasks;

    namespace ExerciciosSinqia
    {
        public class Prova
        {
            public static void Main()
            {
                int acertou = 0, errou = 0; decimal a, b, somar, resposta;

                Console.WriteLine("-------------------");
                Console.WriteLine("Prova de matemática");
                Console.WriteLine("-------------------\n");

                for (int i = 0; i < 5; i++)
                {
                    Random numAleatorio = new Random();
                    a = numAleatorio.Next(1, 100);
                    b = numAleatorio.Next(1, 100);
                    somar = a + b;
                    resposta = somar;

                    Console.Write($"Qual é a soma {a} + {b} = ");
                    resposta = int.Parse(Console.ReadLine());

                    if (resposta != somar)
                    {
                        Console.WriteLine("Essa você errou!");
                        errou++;
                    }
                    else
                    {
                        Console.WriteLine($"Você acertou! = {resposta}");
                        acertou++;
                    }
                }
                Console.WriteLine($"Você acertou {acertou} e errou {errou} questões!");
            }
        }
    }
}