using Microsoft.EntityFrameworkCore;
using ordersSystem.Api.Services;
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
builder.Services.AddScoped(typeof(IUnitOfWork), typeof(PostgresUnitOfWork));

builder.Services.AddScoped(typeof(OrderService));

builder.Services.AddCors(o => o.AddPolicy("CommonPolicy", builder =>
{
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

builder.Services.AddConfiguration(builder.Configuration);

var app = builder.Build();

if  (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
