using System;
using System.Collections.Generic;
using System.Text;

namespace BrisaDoMar
{
    public class Pedido
    {
        public ItemCardapio Item { get; set; } = new ItemCardapio();
        public int Quantidade { get; set; }
        public decimal Total => Item.Preco * Quantidade;
    }
}
