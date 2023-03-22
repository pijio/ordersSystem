using Microsoft.EntityFrameworkCore;
using ordersSystem.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connString = Environment.GetEnvironmentVariable("ConnectionString")
                 ?? builder.Configuration.GetSection("ConnectionStrings")["Current"];
builder.Services.AddDbContext<PostgresContext>(x =>
{
    x.UseNpgsql(connString);
});
builder.Services.AddTransient(typeof(IUnitOfWork<>), typeof(PostgresUnitOfWork));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
