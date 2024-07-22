using CommandPattern.Application.CommandHandler;
using CommandPattern.Application.Commands;
using CommandPattern.Framwork.Abstractions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
#region Register
builder.Services.AddSingleton<ICommandBus, CommandBus>();
builder.Services.AddTransient<ICommandHandler<CreateOrderCommand>, CreateOrderCommandHandler>();
#endregion
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();
