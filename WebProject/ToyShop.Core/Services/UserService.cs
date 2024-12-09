using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToyShop.Core.Contracts;
using ToyShop.Data.Common;
using ToyShop.Data.Models;
using ToyShop.ViewModels.UserProfile;
using ToyShop.Web.Areas.Admin.ViewModels;

namespace ToyShop.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IRepository repo;

        public UserService(UserManager<User> _userManager, RoleManager<IdentityRole<Guid>> _roleManager, IRepository _repo)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            repo = _repo;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
        {
            var allUsers = await userManager.Users.ToArrayAsync();

            ICollection<UserViewModel> userViewModels = new List<UserViewModel>();

            foreach (User user in allUsers)
            {
                var roles = await userManager.GetRolesAsync(user);

                userViewModels.Add(new UserViewModel()
                {
                    Id = user.Id,
                    Email = user.Email!,
                    Roles = roles.ToList()
                });
            }

            return userViewModels;
        }

        public async Task<bool> UserExistsByIdAsync(Guid userId)
        {
            User? user = await userManager
                .FindByIdAsync(userId.ToString());

            return user != null;
        }

        public async Task<bool> AssignUserToRoleAsync(Guid userId, string roleName)
        {
            User? user = await userManager
                .FindByIdAsync(userId.ToString());
            bool roleExists = await roleManager.RoleExistsAsync(roleName);

            if (user == null || !roleExists)
            {
                return false;
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, roleName);
            if (!alreadyInRole)
            {
                IdentityResult? result = await userManager
                    .AddToRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> RemoveUserRoleAsync(Guid userId, string roleName)
        {
            User? user = await userManager
                .FindByIdAsync(userId.ToString());
            bool roleExists = await roleManager.RoleExistsAsync(roleName);

            if (user == null || !roleExists)
            {
                return false;
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, roleName);
            if (alreadyInRole)
            {
                IdentityResult? result = await userManager
                    .RemoveFromRoleAsync(user, roleName);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> DeleteUserAsync(Guid userId)
        {
            User? user = await userManager
                .FindByIdAsync(userId.ToString());

            if (user == null)
            {
                return false;
            }

            IdentityResult? result = await userManager
                .DeleteAsync(user);
            if (!result.Succeeded)
            {
                return false;
            }

            return true;
        }

        public async Task<UserProfileViewModel> GetUserProfileAsync(Guid userId)
        {
            var user = await userManager.Users
                .Include(u => u.Address)
                    .ThenInclude(a => a.City)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException("Невалидна операция!");
            }

            var userProfile = new UserProfileViewModel
            {
                Id = userId,
                FirstName = user.FirstName!,
                LastName = user.LastName!,
                Email = user.Email!,
                PhoneNumber = user.PhoneNumber!,
                Age = user.Age.ToString()!
            };

            if (user.Address != null)
            {
                userProfile.Address = new ViewModels.AddressViewModel
                {
                    Id = user.Address.Id,
                    StreetName = user.Address.StreetName,
                    Number = user.Address.Number,
                    CityId = user.Address.CityId,
                    CityName = user.Address.City.Name,
                    PostCode = user.Address.City.PostCode,
                    BuildingNumber = user.Address.BuildingNumber,
                    Entrance = user.Address.Entrance,
                    OtherAddressInformation = user.Address.OtherAddressInformation,
                };
            }

            return userProfile;
        }
    }
}
