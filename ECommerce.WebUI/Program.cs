using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.DataAcces.Context;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete.EFEntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSession();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductDal,EFProductDal>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ECommerceDb>(opt =>
{
    opt.UseSqlServer(conn);
});
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

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
