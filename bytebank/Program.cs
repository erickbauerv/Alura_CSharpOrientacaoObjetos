using System;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Titular titularAndre = new Titular();
            titularAndre.Nome = "André";
            titularAndre.Profissao = "Padero";
            titularAndre.CPF = "123.431.343-01";

            ContaCorrente contaDoAndre = new ContaCorrente();
            contaDoAndre.Titular = titularAndre;
            contaDoAndre.Conta = "1010-X";
            contaDoAndre.Agencia = 15;
            contaDoAndre.Saldo = 100;

            contaDoAndre.Depositar(100);
        }
    }
}
