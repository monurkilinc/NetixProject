using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Mapping;
using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

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
builder.Services.AddScoped<BussinessLayer.Abstract.IComputerService, BussinessLayer.Concrete.ComputerManager>();

builder.Services.AddAutoMapper(typeof(ServiceProfile));

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
    pattern: "{controller=Personal}/{action=Index}/{id?}");
app.Run();
