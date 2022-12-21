using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public Titular Titular { get; set; }
        public string Conta { get; set; }
        public int Agencia { get; set; }
        private double _saldo;
        public double Saldo
        {
            get { return this._saldo; }
            set 
            {
                if (value > 0)
                {
                    this._saldo = value;
                }
                else
                {
                    Console.WriteLine("O valor a ser definido não pode ser menor que 0");
                }
            }
        }

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
