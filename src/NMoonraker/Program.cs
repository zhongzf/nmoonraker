using NMoonraker.Interfaces;
using NMoonraker.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IServerService, ServerService>();
builder.Services.AddSingleton<IWebSocketService, WebSocketService>();
builder.Services.AddSingleton<IKlippyConnection, KlippyConnection>();
builder.Services.AddSingleton<IKlippyApis, KlippyApis>();

builder.Services.AddCors(option => option.AddPolicy("cors",
  policy => policy.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials()
                  .SetIsOriginAllowed(_ => true)
 ));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("cors");

app.MapControllers();

app.UseWebSockets();

app.Run();
