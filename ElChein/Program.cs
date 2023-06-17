using ElChein.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Conexion base de datos
builder.Services.AddDbContext<ElCheinContext>(options => 
options.UseSqlServer("name=ConnectionStrings:Connection"));

//Servicio de contenedores
builder.Services.AddControllersWithViews();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//Ruta 
app.MapDefaultControllerRoute();


app.Run();
