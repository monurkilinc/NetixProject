using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPersonalService, PersonalManager>();
builder.Services.AddScoped<IComputerService, ComputerManager>();

builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IPersonalDAL, EFPersonalRepository>();
builder.Services.AddScoped<IComputerDAL, EFComputerRepository>();
builder.Services.AddScoped<IAdminDAL, EFAdminRepository>();
builder.Services.AddScoped<IServiceDAL, EFServiceRepository>();

builder.Services.AddScoped<IServiceHistoryService, ServiceHistoryManager>();
builder.Services.AddScoped<IServiceHistoryDAL,EFServiceHistoryRepository>();

builder.Services.AddScoped<DataAccessLayer.EntityFramework.EFComputerRepository>();
builder.Services.AddScoped<DataAccessLayer.EntityFramework.EFServiceHistoryRepository>();
builder.Services.AddScoped<BussinessLayer.Abstract.IComputerService, BussinessLayer.Concrete.ComputerManager>();// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Personal}/{action=Index}/{id?}");
app.Run();
