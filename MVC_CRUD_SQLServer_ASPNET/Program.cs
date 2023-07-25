using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MVC_CRUD_SQLServer_ASPNET.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Esta es una de las l�neas que hay que agregar y modificar para las conexiones ATENCI�N!!!!
builder.Services.AddDbContext<MvccrudContext>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
