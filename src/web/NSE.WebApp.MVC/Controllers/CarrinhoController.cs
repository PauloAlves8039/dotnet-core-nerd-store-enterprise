using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Controllers
{
    public class CarrinhoController : MainController
    {
        [Route("carrinho")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [Route("carrinho/adicionar-item")]
        public async Task<IActionResult> AdicionarItemCarrinho(ItemProdutoViewModel itemProduto) 
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("carrinho/atualizar-item")]
        public async Task<IActionResult> AtualizarItemCarrinho(Guid produtoId, int quantidade)
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("carrinho/remover-item")]
        public async Task<IActionResult> RemoverItemCarrinho(Guid produtoId) 
        {
            return RedirectToAction("Index");
        }

    }
}
