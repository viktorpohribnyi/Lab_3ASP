using LabAspNetApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// ������ CalcService �� TimeService �� ������ � ������� ������ Transient
builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeService>();

// ������ �������� ����������
builder.Services.AddControllers();

var app = builder.Build();

// ������������ ������������� �� ��������
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
