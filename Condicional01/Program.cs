using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com estruturas de condições - If Else
            /*
             * Objetivo: receber nome, cidade, ano de nascimento e CPF
             * Calcular a idade da pessoa e analisar o seguinte:
             * se idade >=18 (passagem autorizada!)
             * se idade <18 (passagem negada!) para isso devemos calcular a idade
            */
            string nome, cidade, CPF;
            int anoNasc, anoAtual, idade;

            //atribuir o ano atual usando datetime
            anoAtual = DateTime.Now.Year;

            Console.WriteLine(anoAtual);

            Console.WriteLine("Informe o nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite o ano de nascimento: ");
            anoNasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o CPF: ");
            CPF = Console.ReadLine();

            idade = anoAtual - anoNasc;

            if (idade >= 18)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Passagem Autorizada!");
            }
            else
            {
                Console.WriteLine(nome);
                Console.WriteLine("Passagem Negada!");
            }

            Console.ReadKey();
        }
    }
}
