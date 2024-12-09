using ToyShop.ViewModels.UserProfile;
using ToyShop.Web.Areas.Admin.ViewModels;

namespace ToyShop.Core.Contracts
{
    public interface IUserService
    {
        public Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        public Task<bool> UserExistsByIdAsync(Guid userId);
        public Task<bool> AssignUserToRoleAsync(Guid userId, string roleName);
        public Task<bool> RemoveUserRoleAsync(Guid userId, string roleName);
        public Task<bool> DeleteUserAsync(Guid userId);
        public Task<UserProfileViewModel> GetUserProfileAsync(Guid userId);
    }

}
