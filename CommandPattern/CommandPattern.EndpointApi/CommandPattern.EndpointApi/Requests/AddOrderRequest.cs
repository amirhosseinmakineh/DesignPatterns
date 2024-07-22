using CommandPattern.Application.Commands;

namespace CommandPattern.EndpointApi.Requests
{
    public record AddOrderRequest:ConvertRequestToCommand<CreateOrderCommand>
    {
        public List<string> FoodName { get; set; } = null;
        public string Price { get; set; } = null;

        public CreateOrderCommand ToCommand()
        {
            var orderCommand = new CreateOrderCommand()
            {
                FoodName = FoodName,
                Price = Price,
            };
            return orderCommand;
        }
    }
    public interface ConvertRequestToCommand<TCommand>
    {
        TCommand ToCommand();
    }
}
