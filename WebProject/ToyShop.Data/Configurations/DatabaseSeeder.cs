using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ToyShop.Data.Models;

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
                var result = roleManager.CreateAsync(new IdentityRole<Guid> { Name = role }).GetAwaiter().GetResult();

                if (!result.Succeeded)
                {
                    throw new Exception($"Неуспешно създаване на роля: {role}");
                }
            }
        }
    }

    public static async Task SeedUsersAsync(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
        var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datasets", "Users.json");
        var jsonData = await File.ReadAllTextAsync(jsonPath);

        var users = JsonSerializer.Deserialize<List<UserSeedModel>>(jsonData);

        foreach (var userData in users!)
        {
            try
            {
                var existingUser = await userManager.FindByEmailAsync(userData.Email);
                if (existingUser == null)
                {
                    var newUser = new User
                    {
                        Id = Guid.Parse(userData.Id),
                        UserName = userData.UserName,
                        Email = userData.Email,
                        FirstName = userData.FirstName,
                        LastName = userData.LastName,
                        Age = userData.Age,
                        PhoneNumber = userData.PhoneNumber,
                        AddressId = userData.AddressId,
                        EmailConfirmed = true,
                        RegistrationDate = DateTime.Now,  // Set the registration date to now or as per your requirement
                        IsActive = true  // Assuming users are active by default
                    };

                    var result = await userManager.CreateAsync(newUser, userData.Password);
                    if (!result.Succeeded)
                    {
                        Console.WriteLine($"Error creating user {userData.Email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                        continue;
                    }

                    existingUser = newUser;
                }

                foreach (var role in userData.Roles)
                {
                    if (!await userManager.IsInRoleAsync(existingUser, role))
                    {
                        var roleResult = await userManager.AddToRoleAsync(existingUser, role);
                        if (!roleResult.Succeeded)
                        {
                            Console.WriteLine($"Error adding role {role} to user {existingUser.Email}: {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding user {userData.Email}: {ex.Message}");
            }
        }
    }

    private class UserSeedModel
    {
        public string Id { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public List<string> Roles { get; set; } = new List<string>();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; } = null!;  // Add this line
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
