using MediatR;
using NSE.Core.Messages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace NSE.Core.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<ValidationResult> EnviarComando<T>(T comando) where T : Command
        {
            throw new NotImplementedException();
        }

        public Task PublicarEvento<T>(T evento) where T : Event
        {
            throw new NotImplementedException();
        }
    }
}
