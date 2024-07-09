using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RajPortfolio.Data;
using RajPortfolio.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RajPortfolioContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RajPortfolioContext") ?? throw new InvalidOperationException("Connection string 'RajPortfolioContext' not found.")));

// Checks which environment we're working in and applies the relevant db
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<RajPortfolioContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("RajPortfolioContext")));
}
else
{
    builder.Services.AddDbContext<RajPortfolioContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionTrackContext")));
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
