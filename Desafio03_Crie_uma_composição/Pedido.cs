using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03_Crie_uma_composição
{
    public class Pedido
    {
        public double Valor;
        public string Cliente;
        public Endereco EndereçoDaEntrega;
        public List<Item> Items;

        public void ExibirInformacoesDoPedido()
        {
            Console.WriteLine($"Preço: {String.Format("0.00", this.Valor)}");
            Console.WriteLine($"Cliente: {this.Cliente}");
            Console.WriteLine($"Endereço: {this.EndereçoDaEntrega.Rua}, {this.EndereçoDaEntrega.Numero}, {this.EndereçoDaEntrega.Bairro}, {this.EndereçoDaEntrega.Cidade}, {this.EndereçoDaEntrega.Estado}");

            Console.WriteLine("Items que foram pedidos:");
            foreach (Item item in this.Items)
            {
                Console.WriteLine($"Item: {item.Nome}");
                Console.WriteLine($"Preço: {String.Format("0.00", this.Valor)}");
            }
        }

        public double CalcularValorDoPedido()
        {
            double valorTotal = 0;
            foreach (Item item in this.Items)
            {
                valorTotal += item.Valor;
            }

            return valorTotal;
        }
    }
}
