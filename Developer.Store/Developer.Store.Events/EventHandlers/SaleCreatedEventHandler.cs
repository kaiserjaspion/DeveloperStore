using Developer.Store.Events.Models;
using Rebus.Handlers;

namespace Developer.Store.Events.EventHandlers
{
    public class SaleCreatedEventHandler : IHandleMessages<SaleCreatedEvent>
    {
        public async Task Handle(SaleCreatedEvent message)
        {
            Console.WriteLine($"{message.Message}");
        }
    }
}
