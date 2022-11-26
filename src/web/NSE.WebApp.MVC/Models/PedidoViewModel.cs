using System;
using System.Collections.Generic;

namespace NSE.WebApp.MVC.Models
{
    public class PedidoViewModel
    {
        public int Codigo { get; set; }

        public int Status { get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }

        public decimal Desconto { get; set; }
        public bool VoucherUtilizado { get; set; }

        public List<ItemPedidoViewModel> PedidoItems { get; set; } = new List<ItemPedidoViewModel>();

        public class ItemPedidoViewModel
        {
            public Guid ProdutoId { get; set; }
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Valor { get; set; }
            public string Imagem { get; set; }
        }

        public EnderecoViewModel Endereco { get; set; }

    }
}
