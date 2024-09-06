using jienigui.Server;
using jienigui.Server.IServer;
using WebApplication1.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IConfiguration configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json")
.Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(new AppConfig(configuration));
builder.Services.AddScoped<IUserServer, UserServer>();




var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
