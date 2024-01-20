using Salao.WebApplication;

var builder = WebApplication.CreateBuilder(args);

// Criar uma inst�ncia da classe Startup
var startup = new Startup(builder.Configuration);

// Adicionar servi�os � inst�ncia da classe Startup
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configurar o pipeline de solicita��o HTTP
startup.Configure(app, builder.Environment);

app.Run();

