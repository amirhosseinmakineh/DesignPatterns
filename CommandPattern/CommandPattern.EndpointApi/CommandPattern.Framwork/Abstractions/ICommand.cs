using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace CommandPattern.Framwork.Abstractions
{
    public interface ICommand
    {
    }
    public interface ICommandBus
    {
        void DisPatch<TCommand>(TCommand command) where TCommand : ICommand;
    }
    public class CommandBus : ICommandBus
    {
        private readonly IServiceProvider serviceProvider;

        public CommandBus(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void DisPatch<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = serviceProvider.GetRequiredService<IEnumerable<ICommandHandler<TCommand>>>().ToList();
            foreach(var handler in handlers)
            {
                handler.Handle(command);
            };
        }
    }
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}
