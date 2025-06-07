using WardrobeInventory.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WardrobeInventory.Data;
using WardrobeInventory.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<WardrobeInventoryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WardrobeInventoryContext") ??
    throw new InvalidOperationException("Connection string 'WardrobeInventoryContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddTransient<IWardrobeService, WardrobeServiceEntityFramework>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();


app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
