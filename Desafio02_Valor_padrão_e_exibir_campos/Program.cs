using System;

namespace Desafio02_Valor_padrão_e_exibir_campos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Alura: {String.Format("0.00", pessoa.Altura)}");
            Console.WriteLine($"Peso: {String.Format("0.00", pessoa.Peso)}");

            Console.ReadLine();
        }
    }
}
