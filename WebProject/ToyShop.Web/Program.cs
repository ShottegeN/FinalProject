using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Core.Services;
using ToyShop.Data;
using ToyShop.Data.Common;
using ToyShop.Data.Configurations;
using ToyShop.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ToyShopDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IRepository, Repository>()
    .AddScoped<IUserService, UserService>()
    .AddScoped<IProductService, ProductService>()
    .AddScoped<IPromotionService, PromotionService>()
    .AddScoped<ICategoryService, CategoryService>()
    .AddScoped<IOrderService, OrderService>()
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

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";  // Customize the login path
    options.AccessDeniedPath = "/Identity/Account/AccessDenied"; // Customize the access denied path    
});

// NOT IMPLEMENTED!
//builder.Services.AddAuthentication()
//    .AddGoogle(options =>
//    {
//        options.ClientId = builder.Configuration["Authentication:Google:ClientId"]!;
//        options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;
//    })
//    .AddFacebook(options =>
//    {
//        options.AppId = builder.Configuration["Authentication:Facebook:AppId"];
//        options.AppSecret = builder.Configuration["Authentication:Facebook:AppSecret"];
//    });

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    DatabaseSeeder.SeedRoles(services);
    DatabaseSeeder.AssignAdminRole(services);
}

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

app.Use((context, next) =>
{
    if (context.User.Identity?.IsAuthenticated == true && context.Request.Path == "/")
    {
        if (context.User.IsInRole("Administrator"))
        {
            context.Response.Redirect("/Admin/Home/Index");
            return Task.CompletedTask;
        }
    }

    return next();
});

app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");    

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
    //Lockout
    options.Lockout.DefaultLockoutTimeSpan =
        builder.Configuration.GetValue<TimeSpan>("Identity:Lockout:DefaultLockoutTimeSpan");
    options.Lockout.MaxFailedAccessAttempts =
        builder.Configuration.GetValue<int>("Identity:Lockout:MaxFailedAccessAttempts");
    options.Lockout.AllowedForNewUsers =
        builder.Configuration.GetValue<bool>("Identity:Lockout:AllowedForNewUsers");
}
