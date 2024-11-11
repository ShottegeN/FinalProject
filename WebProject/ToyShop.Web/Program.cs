using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.Data;
using ToyShop.Data.Common;
using ToyShop.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ToyShopDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IRepository, Repository>()
    .AddScoped<IProductService, ProductService>()
    .AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<User, IdentityRole<Guid>>(options =>
{
    ConfigureIdentity(builder, options);
})
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<ToyShopDbContext>()
    .AddSignInManager<SignInManager<User>>()
    .AddUserManager<UserManager<User>>()
    .AddDefaultTokenProviders()
    .AddTokenProvider<DataProtectorTokenProvider<User>>("Default");


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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

static void ConfigureIdentity(WebApplicationBuilder builder, IdentityOptions options)
{
    //Password
    options.Password.RequireDigit =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireDigits");
    options.Password.RequireLowercase =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
    options.Password.RequireUppercase =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
    options.Password.RequireNonAlphanumeric =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumerical");
    options.Password.RequiredLength =
        builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
    options.Password.RequiredUniqueChars =
        builder.Configuration.GetValue<int>("Identity:Password:RequiredUniqueCharacters");
    //SignIn
    options.SignIn.RequireConfirmedAccount =
        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
    options.SignIn.RequireConfirmedEmail =
        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedEmail");
    options.SignIn.RequireConfirmedPhoneNumber =
        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedPhoneNumber");
    //User
    options.User.RequireUniqueEmail =
        builder.Configuration.GetValue<bool>("Identity:User:RequireUniqueEmail");
    options.User.AllowedUserNameCharacters =
        builder.Configuration.GetValue<string>("Identity:User:AllowedUserNameCharacters")!;
    // Lockout
    options.Lockout.DefaultLockoutTimeSpan =
        builder.Configuration.GetValue<TimeSpan>("Identity:Lockout:DefaultLockoutTimeSpan");
    options.Lockout.MaxFailedAccessAttempts =
        builder.Configuration.GetValue<int>("Identity:Lockout:MaxFailedAccessAttempts");
    options.Lockout.AllowedForNewUsers =
        builder.Configuration.GetValue<bool>("Identity:Lockout:AllowedForNewUsers");
}
