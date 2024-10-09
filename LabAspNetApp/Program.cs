using LabAspNetApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Додаємо CalcService та TimeService як сервіси з життєвим циклом Transient
builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeService>();

// Додаємо підтримку контролерів
builder.Services.AddControllers();

var app = builder.Build();

// Налаштування маршрутизації та ендпоінтів
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
