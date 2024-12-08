using TaskSystem.CoreApplication.Interfaces;
using TaskSystem.CoreApplication.Services;
using TaskSystem.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// here we used dependency injection of the different classes of our app,
// we used AddScoped to insure that the we create only one instance for each request to those services
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITaskService, TaskService>();
//Add Singleton ensure that only one instance is shared between the different classes of our app
builder.Services.AddSingleton<Type>(t => typeof(GenericRepository<>));
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
