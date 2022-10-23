using ePizzaHub.Entities;
using ePizzaHub.Services.Interfaces;
using ePizzaHub.Services.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        protected SignInManager<User> _signManager;
        protected UserManager<User> _userManager;

        protected RoleManager<Role> _roleManager;

        public AuthenticationService(SignInManager<User> signManager, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _signManager = signManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public User AuthenticateUser(string Username, string Password)
        {
            var result = _signManager.PasswordSignInAsync(Username, Password, false, lockoutOnFailure: false).Result;
            if (result.Succeeded)
            {
                var user = _userManager.FindByNameAsync(Username).Result;
                var roles = _userManager.GetRolesAsync(user).Result;
                user.Roles = roles.ToArray();

                return user;
            }
            return null;
        }

        public Response CreateUser(User user, string Password)
        {
            var result = _userManager.CreateAsync(user, Password).Result;
           //var message = result.Errors.First().Description;

            List<IdentityError> errorList = result.Errors.ToList();
            var errors = string.Join(", ", errorList.Select(e => e.Description));


            Response response = new Response();
           
            response.Status = result.Succeeded;
            //response.Message = message;
            response.Error = errors;
            
            if (result.Succeeded)
            {
                //Admin, User
                string role = "Admin";
                var res = _userManager.AddToRoleAsync(user, role).Result;
                if (res.Succeeded)
                {
                    return response;
                }
                
            }
            return response;
        }

        public User GetUser(string Username)
        {
            return _userManager.FindByNameAsync(Username).Result;
        }

        public async Task<bool> SignOut()
        {
            try
            {
                await _signManager.SignOutAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
