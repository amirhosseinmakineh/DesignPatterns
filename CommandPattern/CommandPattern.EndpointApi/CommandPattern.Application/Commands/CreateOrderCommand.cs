using CommandPattern.Framwork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CommandPattern.Application.Commands
{
    public class CreateOrderCommand:ICommand
    {
        public List<string> FoodName { get; set; } = null;
        public string Price { get; set; } = null;
    }
}
