using CommandPattern.Application.Commands;
using CommandPattern.EndpointApi.Requests;
using CommandPattern.Framwork.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CommandPattern.EndpointApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ICommandBus commandBus;

        public OrdersController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }
        [HttpPost]
        public IActionResult CreateOrder(AddOrderRequest request)
        {
            commandBus.DisPatch(request.ToCommand());
            return Created("",null);
        }
    }
}
