using Microsoft.AspNetCore.Mvc;
using NSE.Carrinho.API.Model;
using NSE.WebApp.MVC.Controllers;
using System;
using System.Threading.Tasks;

namespace NSE.Carrinho.API.Controllers
{
    public class CarrinhoController : MainController
    {
        [HttpGet("carrinho")]
        public async Task<CarrinhoCliente> ObterCarrinho()
        {
            return null;
        }

        [HttpPost("carrinho")]
        public async Task<IActionResult> AdicionarItemCarrinho(CarrinhoItem item) 
        {
            return null;
        }

        [HttpPut("carrinho/{produtoId}")]
        public async Task<IActionResult> AtualizarItemCarrinho(Guid produtoId, CarrinhoItem item) 
        {
            return null;
        }

        [HttpDelete("carrinho/{produtoId}")]
        public async Task<IActionResult> RemoverItemCarrinho(Guid produtoId) 
        {
            return null;
        }
    }
}
