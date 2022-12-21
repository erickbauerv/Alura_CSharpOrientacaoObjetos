using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public Titular Titular;
        public string Conta;
        public int Agencia;
        public double Saldo;

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Não foi possível fazer o saque");
            }
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (this.Saldo < valor || valor <= 0)
            {
                Console.WriteLine("Não foi possível fazer a transferência");
            }
            else
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
            }
        }
    }
}
