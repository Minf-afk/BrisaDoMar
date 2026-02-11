using System;
using System.Collections.Generic;
using System.Text;

namespace BrisaDoMar
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
        public decimal ValorDaMesa => Pedidos.Sum(p => p.Total);

        public bool Reservada {  get; set; }
    }
}
