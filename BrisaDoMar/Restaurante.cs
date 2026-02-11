    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace BrisaDoMar
    {
        public class Restaurante
        {
            public string NomeRestaurante { get; set; }

            public List<Mesa> Mesas { get; set; } = new List<Mesa>();
            public List<ItemCardapio> Cardapio { get; set; } = new List<ItemCardapio>();

        }
    }
