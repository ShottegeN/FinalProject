using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToyShop.Data;
using ToyShop.Data.Common;
using ToyShop.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ToyShopDbContext>(options =>
    options.UseSqlServer(connectionString))
    .AddScoped<IRepository, Repository>()
    .AddDatabaseDeveloperPageExceptionFilter()
    .AddDefaultIdentity<User>(options =>
     {
         options.SignIn.RequireConfirmedAccount = false;
         options.Password.RequireDigit = false;
         options.Password.RequireNonAlphanumeric = false;
         options.Password.RequireUppercase = false;
     })
    .AddEntityFrameworkStores<ToyShopDbContext>();

//builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ToyShopDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
