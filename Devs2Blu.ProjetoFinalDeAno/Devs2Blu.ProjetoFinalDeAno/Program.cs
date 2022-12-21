using Devs2Blu.ProjetoFinalDeAno.Repository;
using Devs2Blu.ProjetoFinalDeAno.Services.Implements;
using Devs2Blu.ProjetoFinalDeAno.Services.Interfaces;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ContextoDatabase>
    (options => options.UseSqlServer("Server=ROBERTO-PC\\SQLEXPRESS;Database=Pizzaria;User Id=sa;Password=admin;TrustServerCertificate=True;"));

// Repositories
builder.Services.AddScoped<ClienteRepository, ClienteRepository>();
builder.Services.AddScoped<ConfiguraSistemaRepository, ConfiguraSistemaRepository>();
builder.Services.AddScoped<EnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<NewsletterRepository, NewsletterRepository>();
builder.Services.AddScoped<PedidoRepository, PedidoRepository>();
builder.Services.AddScoped<PizzaRepository, PizzaRepository>();

// Services
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IConfiguraSistema, ConfiguraSistemaService>();
builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddScoped<INewsletterService, NewsletterService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IPizzaService, PizzaService>();

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
