using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AgentUI.Context;
using AgentUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgentUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly EmlakDBContext _context;
        public AccountController(EmlakDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User loginModel)
        {
            if (LoginUser(loginModel.UserName, loginModel.Password))
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.UserName),
                new Claim(ClaimTypes.NameIdentifier, loginModel.ID.ToString())
            };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                

                //Just redirect to our index after logging in. 
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        public IActionResult PasswordChange()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordChange(PasswordChangeModel model)
        {
            var username = User.Claims.Where(c => c.Type == ClaimTypes.Name)
               .Select(c => c.Value).SingleOrDefault();

            var user = _context.Users.Where(x => x.UserName == username && x.Password == model.Password).FirstOrDefault();
            if (user != null)
            {
                user.Password = model.NewPassword;
                _context.SaveChanges();
                return Redirect("/Home/Index");
            }
            

            return View();
        }

        private bool LoginUser(string username, string password)
        {
            var user = _context.Users.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            
            if (user !=null)
                return true;
            else
                return false;

        }
    }
}