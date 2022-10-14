using MediatR;
using FluentValidation.Results;
using System.Threading;
using System.Threading.Tasks;
using NSE.Costumer.API.Models;
using NSE.Core.Messages;

namespace NSE.Costumer.API.Application.Commands
{
    public class ClienteCommandHandler : CommandHandler, IRequestHandler<RegistrarClienteCommand, ValidationResult>
    {
        public async Task<ValidationResult> Handle(RegistrarClienteCommand message, CancellationToken cancellationToken)
        {
            if (!message.EhValido()) return message.ValidationResult;

            var cliente = new Cliente(message.Id, message.Nome, message.Email, message.Cpf);

            return message.ValidationResult;

        }
    }
}
