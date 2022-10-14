﻿using NSE.Core.Messages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace NSE.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<ValidationResult> EnviarComando<T>(T comando) where T : Command;
    }
}