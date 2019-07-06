using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    public class Ping : IRequest<PingOut>, INotification
    {
        public string Name { get; set; }
    }

    public class PingHandler : IRequestHandler<Ping, PingOut>
    {
        public Task<PingOut> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new PingOut());
        }
    }

    public class PingN1 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
    public class PingN2 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
