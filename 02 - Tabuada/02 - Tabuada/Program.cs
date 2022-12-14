using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSinqia
{
    public class Ex01_Tabuada
    {

        public static void Main()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*         Tabuada             *");
            Console.WriteLine("*******************************");

            bool sucesso;
            int num;

            do
            {
                Console.Write("Digite um número: ");
                sucesso = int.TryParse(Console.ReadLine(), out num);
            } while (!sucesso);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }
    }
}
