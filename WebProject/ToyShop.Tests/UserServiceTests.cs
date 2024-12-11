using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using MockQueryable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toyshop.Tests;
using ToyShop.Core.Services;
using ToyShop.Data.Common;
using ToyShop.Data.Models;

namespace ToyShop.Tests
{
    class UserServiceTests
    {
        static readonly Random random = new Random();

        Mock<IRepository> mockRepo;
        Mock<UserManager<User>> userManager;
        Mock<RoleManager<IdentityRole<Guid>>> roleManager;
        UserService userServiceTest;

        List<User> SetupUsers(int usersCnt)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < usersCnt; i++)
            {
                User usr = new User() { UserName = "User_" + i, Email = $"TestEmail{i}@Test.test"};
                users.Add(usr);
            }
            return users;
        }

        List<IdentityRole<Guid>> SetupRoles(int rolesCnt)
        {
            List<IdentityRole<Guid>> roles = new List<IdentityRole<Guid>>();
            for (int i = 0; i < rolesCnt; i++)
            {
                IdentityRole<Guid> role = new IdentityRole<Guid>() { Name = "Role_" + i };
                roles.Add(role);
            }
            return roles;
        }

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<IRepository>();
            var userStoreMock = new Mock<IUserStore<User>>();
            userManager = new Mock<UserManager<User>>(userStoreMock.Object, null, null, null, null, null, null, null, null);

            var roleStoreMock = new Mock<IRoleStore<IdentityRole<Guid>>>();
            roleManager = new Mock<RoleManager<IdentityRole<Guid>>>(roleStoreMock.Object, null, null, null, null);

            userServiceTest = new UserService(userManager.Object, roleManager.Object, mockRepo.Object);
        }

        [Test,Repeat(50)]
        public async Task TestGetAllUsersAsync()
        {
            int usersCnt = random.Next(1,20);
            List<User> users = SetupUsers(usersCnt);

            int rolesCnt = random.Next(20);
            List<IdentityRole<Guid>> roles = SetupRoles(rolesCnt);

            IQueryable<User> mockUsers = users.BuildMock();
            userManager.Setup(r => r.Users).Returns(mockUsers.AsQueryable());

            userManager.Setup(x => x.GetRolesAsync(It.IsAny<User>())).ReturnsAsync((IList<string>)new List<string> { "Admin", "User" });

            var result = await userServiceTest.GetAllUsersAsync();
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(usersCnt));

            foreach (var res in result)
            {
                var usr = users.Where(x => x.Id == res.Id).FirstOrDefault();
                Assert.NotNull(usr);
                Assert.That(res.Roles, Is.EqualTo(new object[]{ "Admin", "User"}));

            }
        }

        [Test, Repeat(50)]
        public async Task TestUserExistsByIdAsync()
        {
            int usersCnt = random.Next(1, 20);
            List<User> users = SetupUsers(usersCnt);

            userManager.Setup(r => r.FindByIdAsync(It.IsAny<string>())).Returns<string>(id =>
            {
                return Task.FromResult(users.Where(x => x.Id.ToString() == id).FirstOrDefault());
            });

            foreach (var user in users)
            {
                bool exists = await userServiceTest.UserExistsByIdAsync(user.Id);

                Assert.IsTrue(exists);
            }
        }

        [Test, Repeat(50)]
        public async Task TestAssignUserToRoleAsync()
        {
            int usersCnt = random.Next(1, 20);
            List<User> users = SetupUsers(usersCnt);

            int rolesCnt = random.Next(20);
            List<IdentityRole<Guid>> roles = SetupRoles(rolesCnt);

            Dictionary<User, List<string>> usrRoles = new Dictionary<User, List<string>>();

            userManager.Setup(r => r.FindByIdAsync(It.IsAny<string>())).Returns<string>(id =>
            {
                return Task.FromResult(users.Where(x => x.Id.ToString() == id).FirstOrDefault());
            });

            roleManager.Setup(r => r.RoleExistsAsync(It.IsAny<string>())).Returns<string>(id =>
            {
                return Task.FromResult(roles.Where(x => x.Name == id).Any());
            });

            userManager.Setup(r => r.IsInRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns<User,string>((usr,roleName) =>
            {
                return Task.FromResult(usrRoles.ContainsKey(usr) && usrRoles[usr].Contains(roleName));
            });

            userManager.Setup(r => r.AddToRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns<User, string>((usr, roleName) =>
            {
                if (!usrRoles.ContainsKey(usr)) usrRoles.Add(usr, new List<string>());
                usrRoles[usr].Add(roleName);
                return Task.FromResult(IdentityResult.Success);
            });

            foreach (var user in users)
            {
                foreach(var role in roles)
                {
                    var res = await userServiceTest.AssignUserToRoleAsync(user.Id, role.Name);
                    Assert.IsTrue(res);
                    Assert.IsTrue(usrRoles[user].Contains(role.Name)); 
                }
            }
        }

        [Test, Repeat(50)]
        public async Task TestRemoveUserRoleAsync()
        {
            int usersCnt = random.Next(1, 20);
            List<User> users = SetupUsers(usersCnt);

            int rolesCnt = random.Next(20);
            List<IdentityRole<Guid>> roles = SetupRoles(rolesCnt);

            Dictionary<User, List<string>> usrRoles = new Dictionary<User, List<string>>();
            foreach(var usr in users)
            {
                foreach(var role in roles)
                {
                    if (!usrRoles.ContainsKey(usr)) usrRoles.Add(usr, new List<string>());
                    usrRoles[usr].Add(role.Name);
                }
            }

            userManager.Setup(r => r.FindByIdAsync(It.IsAny<string>())).Returns<string>(id =>
            {
                return Task.FromResult(users.Where(x => x.Id.ToString() == id).FirstOrDefault());
            });

            roleManager.Setup(r => r.RoleExistsAsync(It.IsAny<string>())).Returns<string>(id =>
            {
                return Task.FromResult(roles.Where(x => x.Name == id).Any());
            });

            userManager.Setup(r => r.IsInRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns<User, string>((usr, roleName) =>
            {
                return Task.FromResult(usrRoles.ContainsKey(usr) && usrRoles[usr].Contains(roleName));
            });

            userManager.Setup(r => r.RemoveFromRoleAsync(It.IsAny<User>(), It.IsAny<string>())).Returns<User, string>((usr, roleName) =>
            {
                if (!usrRoles.ContainsKey(usr) || !usrRoles[usr].Exists(x => x == roleName))
                {
                    return Task.FromResult(IdentityResult.Failed(new IdentityError() { Code = "Invalid Role for user" }));
                }
                usrRoles[usr].Remove(roleName);
                return Task.FromResult(IdentityResult.Success);
            });

            foreach (var user in users)
            {
                foreach (var role in roles)
                {
                    var res = await userServiceTest.RemoveUserRoleAsync(user.Id, role.Name);
                    Assert.IsTrue(res);
                    Assert.IsFalse(usrRoles[user].Contains(role.Name));
                }
            }
        }

        [Test, Repeat(50)]
        public async Task TestDeleteUserAsync()
        {
            int usersCnt = random.Next(1, 20);
            List<User> users = SetupUsers(usersCnt);

            userManager.Setup(r => r.FindByIdAsync(It.IsAny<string>())).Returns<string>(id =>
            {
                return Task.FromResult(users.Where(x => x.Id.ToString() == id).FirstOrDefault());
            });

            userManager.Setup(r => r.DeleteAsync(It.IsAny<User>())).Returns<User>(usr =>
            {
                if (!users.Contains(usr))
                {
                    return Task.FromResult(IdentityResult.Failed(new IdentityError() { Code = "User does not exist" }));
                }
                users.Remove(usr);
                return Task.FromResult(IdentityResult.Success);
            });

            foreach (var userId in users.Select(x => x.Id).ToList())
            {
                bool res = await userServiceTest.DeleteUserAsync(userId);
                Assert.IsTrue(res);
            }
            Assert.IsFalse(users.Any());

        }

        [Test, Repeat(50)]
        public async Task TestGetUserProfileAsync()
        {
            int usersCnt = random.Next(10, 20);
            IList<User> users = SetupUsers(usersCnt);
            int idx = 0;
            foreach(var user in users)
            {
                user.FirstName = "FirstName" + idx;
                user.LastName = "FirstName" + idx;
                user.PhoneNumber = "PhoneNumber" + idx;
                user.Age = random.Next(18, 65);
                if (random.Next(0, 10) % 2 == 0)
                {
                    City city = new City() { Name = "City" + idx, PostCode = random.Next(1, 10000).ToString() };
                    user.Address = new Address()
                    {
                        Id = 10 * idx,
                        StreetName = "Street" + idx,
                        Number = random.Next(1, 100),
                        City = city,
                        CityId = idx,
                        BuildingNumber = random.Next(1, 100),
                        Entrance = random.Next('A', 'Z').ToString(),
                    };
                }
            }

            IQueryable<User> mockUsers = users.BuildMock();
            userManager.Setup(r => r.Users).Returns(mockUsers.AsQueryable());

            foreach(var user in users)
            {
                var res = await userServiceTest.GetUserProfileAsync(user.Id);
                Assert.That(res.Id, Is.EqualTo(user.Id));
                if (user.Address == null)
                {
                    Assert.That(res.Address.Id, Is.EqualTo(0));
                }
                else
                {
                    Assert.That(res.Address.Id, Is.EqualTo(user.Address.Id));
                }
            }
        }
    }
}
