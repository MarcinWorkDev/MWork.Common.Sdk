using System.Threading;
using System.Threading.Tasks;

namespace MWork.Common.Sdk.CQRS
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, ICorrelationContext context, CancellationToken cancellationToken);
    }
}