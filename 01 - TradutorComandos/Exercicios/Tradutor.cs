using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula6
{
    public class Dicionario
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dicionario = new();

            dicionario["if"] = "se";
            dicionario["while"] = "enquanto";
            dicionario[">"] = "maior que";
            dicionario["<"] = "menor que";
            dicionario[">="] = "maior igual que";
            dicionario["<="] = "menor igual que";
            dicionario["=="] = "igual a";
            dicionario["!="] = "diferente de";

            Console.WriteLine("Bem-vindo ao dicionário de comandos C#");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("Digite o comando C# que você quer traduzir:");

            string comando = Console.ReadLine();

            string[] comandos = comando.Split(" ");

            bool chaveEncontrada;

            string resposta = string.Empty;

            foreach (string cmd in comandos)
            {
                chaveEncontrada = dicionario.TryGetValue(cmd, out string traducao);

                if (chaveEncontrada)
                {
                    resposta += traducao + " ";
                }
                else
                {
                    resposta += cmd + " ";
                }
            }

            Console.WriteLine($"A tradução do comando {comando} é {resposta.Trim()}.");
        }
    }
}