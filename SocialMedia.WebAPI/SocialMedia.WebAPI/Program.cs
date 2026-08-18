using BusinessLogic.Cuentas;
using BusinessLogic.Usuarios;
using BusinessLogic.Contenido;

var builder = WebApplication.CreateBuilder(args);
#region dependencias

builder.Services.AddScoped<IUsuariosBusiness, UsuariosBusiness>();
builder.Services.AddScoped<ICuentasBusiness, CuentasBusiness>();
builder.Services.AddScoped<IContenidoBusiness, ContenidoBusiness>();

#endregion
// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
