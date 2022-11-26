using DependencyInjectionMethods.Teste;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ITesteSingleton, TesteSingleton>();
builder.Services.AddScoped<ITesteScoped, TesteScoped>();
builder.Services.AddTransient<ITesteTransient, TesteTransient>();


//Conclus�o
//O tipo de inje��o de depend�ncia ue voc� ir� usar depende do tempo de vida do seu objeto, por exemplo:

//Se voc� nao precisa manter o estado do objeto, use TRANSIENT
//Se precisa compatilhar dados dentro da mesma chamada, use SCOPED
//E se precisar manter os �mesmos� dados durante toda a aplica��o, use SINGLETON.

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
