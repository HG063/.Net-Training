using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarshitIdentityApp.Models;
using Microsoft.AspNetCore.Identity;

namespace HarshitIdentityApp.Controllers
{
    public class AccountsController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public AccountsController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager; this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel model)   //User Registration
        {
            IdentityUser user = new IdentityUser { UserName = model.Email, Email = model.Email };
            IdentityResult result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                ViewBag.msg = "User registerd successfully...";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel model)
        {
            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                //ViewBag.msg = "Login success...";
                return RedirectToAction("dashboard");
            }
            else
            {

                ViewBag.msg = "invalid input credentials...";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult SignOutt()
        {
            return View();
        }
    }
}
