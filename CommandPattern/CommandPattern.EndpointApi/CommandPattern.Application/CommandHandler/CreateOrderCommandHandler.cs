using CommandPattern.Application.Commands;
using CommandPattern.Framwork.Abstractions;

namespace CommandPattern.Application.CommandHandler
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand>
    {
        public void Handle(CreateOrderCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
