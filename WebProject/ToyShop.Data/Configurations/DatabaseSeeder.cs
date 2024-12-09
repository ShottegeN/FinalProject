using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ToyShop.Data.Models;

namespace ToyShop.Data.Configurations
{
    public static class DatabaseSeeder
    {
        public static void SeedRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            string[] roles = { "Administrator", "Moderator", "User" };

            foreach (var role in roles)
            {
                var roleExist = roleManager.RoleExistsAsync(role).GetAwaiter().GetResult();

                if (!roleExist)
                {
                    var result = roleManager.CreateAsync(new IdentityRole<Guid> { Name = role}).GetAwaiter().GetResult();

                    if (!result.Succeeded)
                    {
                        throw new Exception($"Неуспешно създаване на роля: {role}");
                    }
                }
            }
        }

        public static void AssignAdminRole(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            string adminEmail = "admin@gmail.com";
            string adminPassword = "Asd123.";

            var adminUser = userManager.FindByEmailAsync(adminEmail).GetAwaiter().GetResult();

            if (adminUser == null)
            {
                var newAdmin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail,                    
                    EmailConfirmed = true
                };

                var result = userManager.CreateAsync(newAdmin, adminPassword).GetAwaiter().GetResult();

                if (!result.Succeeded)
                {
                    throw new Exception($"Неуспешно създаване на администратор: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                }

                adminUser = newAdmin;
            }

            var isAdmin = userManager.IsInRoleAsync(adminUser, "Administrator").GetAwaiter().GetResult();

            if (!isAdmin)
            {
                var roleResult = userManager.AddToRoleAsync(adminUser, "Administrator").GetAwaiter().GetResult();

                if (!roleResult.Succeeded)
                {
                    throw new Exception($"Failed to assign 'Administrator' role: {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
                }
            }
        }

    }
}
