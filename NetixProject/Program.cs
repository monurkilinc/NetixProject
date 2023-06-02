using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using NetixProject.Controlles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPersonalService, PersonalManager>();
builder.Services.AddScoped<IComputerService, ComputerManager>();
builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IPersonalDAL, EFPersonalRepository>();
builder.Services.AddScoped<IComputerDAL, EFComputerRepository>();
builder.Services.AddScoped<IAdminDAL, EFAdminRepository>();
builder.Services.AddScoped<IServiceDAL, EFServiceRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Personal}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
