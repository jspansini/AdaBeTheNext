using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSinqia
{
    public class ImpressaoFormatada
    {

        public static void Main()
        {
            string[] nomes = { "aline", "carla", "mari", "jess" };
            decimal[] notas = { 9.0M, 5.0M, 3.0M, 10.0M };

            Console.WriteLine($"ALUNO(A)\tNOTAS");
            Console.WriteLine("========\t======");

            for (int i = 0; i < nomes.Length; i++)
            {
                if (notas[i] == 10.0M)
                {
                    Console.WriteLine($"{nomes[i]} \t \t DEZ");
                }
                else
                {
                    Console.WriteLine($"{nomes[i]} \t \t {notas[i]}");
                }
            }
        }
    }
}