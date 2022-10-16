using Microsoft.AspNetCore.Mvc;
using NSE.Core.Mediator;
using NSE.Costumer.API.Application.Commands;
using NSE.WebAPI.Core.Controllers;
using System;
using System.Threading.Tasks;

namespace NSE.Costumer.API.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index() 
        {
            var resultado = await _mediatorHandler.EnviarComando(new RegistrarClienteCommand(Guid.NewGuid(), "Paulo", "paulo@myhome.com", "48457038079"));

            return CustomResponse(resultado);
        }
    }
}
