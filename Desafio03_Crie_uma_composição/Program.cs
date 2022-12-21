using System;
using System.Collections.Generic;

namespace Desafio03_Crie_uma_composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.Cliente = "Manoel Gomes";

            pedido.EndereçoDaEntrega = new Endereco();
            pedido.EndereçoDaEntrega.Rua = "Rua do Manoel";
            pedido.EndereçoDaEntrega.Numero = "12";
            pedido.EndereçoDaEntrega.Bairro = "Bairro Caneta";
            pedido.EndereçoDaEntrega.Cidade = "Cidade";
            pedido.EndereçoDaEntrega.Estado = "Curitiba";

            Item item01 = new Item();
            item01.Nome = "Cup Noodles de Carne";
            item01.Valor = 2.00;
            Item item02 = new Item();
            item02.Nome = "Miojo de Carne";
            item02.Valor = 4.50;


            pedido.Items = new List<Item>();
            pedido.Items.Add(item01);
            pedido.Items.Add(item02);

            pedido.Valor = pedido.CalcularValorDoPedido();

            pedido.ExibirInformacoesDoPedido();

            Console.ReadLine();
        }
    }
}
