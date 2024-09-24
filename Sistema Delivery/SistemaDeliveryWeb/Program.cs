using Microsoft.EntityFrameworkCore;
using SistemaDeliveryWeb.Database;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//obter string de conexão
var connection = builder.Configuration.GetConnectionString("DefaultConnection");

//serviço para registrar o contexto
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");   
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
