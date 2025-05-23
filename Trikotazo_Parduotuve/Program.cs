using Microsoft.EntityFrameworkCore;
using Trikotazo_Parduotuve;
using Trikotazo_Parduotuve.Components;
using Trikotazo_Parduotuve.Repositories;
using Trikotazo_Parduotuve.Entities;
using System.Net.NetworkInformation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Replace your existing DbContext configuration with:
builder.Services.AddDbContext<StoreDataContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));


builder.Services.AddScoped<KategorijaRepository>();
builder.Services.AddScoped<SubkategorijaRepository>();
builder.Services.AddScoped<F1Repository>();
builder.Services.AddScoped<TiekejasRepository>();
builder.Services.AddScoped<TrikotazasRepository>();
builder.Services.AddScoped<AtaskaitaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
