# Condicional01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCondicional1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com Estruturas de condições - IF Else
            /*
             * objetivo: receber nome,cidade,ano de nascimento e cpf calcular a idade da pessoa e analisar o seguinte:
             * se idade >=18 (passagem autorizada!)
             * se idade <18 (passagem negada!)
             * para isso deveremos calcular a idade da pessoa!
             */
            string nome, cidade, cpf;
            int anoNasc, anoAtual, idade;

  //atribuir o ano atual usando datetime
            anoAtual = DateTime.Now.Year;

  Console.WriteLine("Preencha os campos:");
            Console.WriteLine("Nome: ");
            nome= Console.ReadLine();

  Console.WriteLine("Cidade: ");
            cidade= Console.ReadLine();

  Console.WriteLine("CPF: ");
            cpf= Console.ReadLine();

  Console.WriteLine("Ano de Nascimento: ");
            anoNasc=Convert.ToInt32(Console.ReadLine());

  idade = anoAtual - anoNasc;

  if (idade >=18)
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
