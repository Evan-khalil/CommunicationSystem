using CommunicationApp.Models;
using CommunicationApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunicationApp.ViewModels;

namespace CommunicationApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPersonRepository _person;
        private readonly UserManager<Person> _userManager;
        private readonly SignInManager<Person> _signInManager;

        public AccountController(UserManager<Person> userManager, IPersonRepository personRepository, SignInManager<Person> signInManager)
        {
            _userManager = userManager;
            _person = personRepository;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity != null)
            {
                var model = await _person.GetByUserName(User.Identity.Name);
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Person model)
        {
            var entity = await _person.GetById(model.Id);

            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.PhoneNumber = model.PhoneNumber;
            entity.Subscriber = model.Subscriber;

            _person.Update(entity);
            await _person.Save();

            return View(model);
        }

        public IActionResult Email()
        {

            var model = new Email
            {
                OldEmail = User.Identity.Name
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Email(Email model)
        {

            var user = await _userManager.GetUserAsync(User);
            //var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //var changePasswordResult = await _userManager.ChangeEmailAsync(user, model.NewEmail, emailConfirmationToken);
            //await _userManager.ConfirmEmailAsync(user, emailConfirmationToken);
            await _userManager.SetEmailAsync(user, model.NewEmail);
            await _userManager.SetUserNameAsync(user, model.NewEmail);
            await _userManager.UpdateAsync(user);
            await _userManager.UpdateNormalizedUserNameAsync(user);

            await _signInManager.SignOutAsync();
           
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassword model)
        {
            var user = await _userManager.GetUserAsync(User);
            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Role()
        {
            var adminRole = await _userManager.GetUsersInRoleAsync("Admin");
            var adminPersons = adminRole.ToList();
            var allPersons = await _person.GetAll();
            var userPersons = new List<Person>();

            foreach (var person in allPersons)
            {
                var isAdmin = false;

                foreach (var admin in adminPersons)
                {
                    if (admin.Id == person.Id) { isAdmin = true; }
                }

                if (!isAdmin) { userPersons.Add(person); }
            }

            var model = new UserRole { Admins = adminRole.ToList(), Users = userPersons };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Role(UserRole model)
        {
            var adminRole = await _userManager.GetUsersInRoleAsync("Admin");
            var isAdmin = adminRole.Any(p => p.Id == model.Person);
            var person = await _person.GetById(model.Person);

            if (model.RoleName == "Admin")
            {
                if (!isAdmin) { await _userManager.AddToRoleAsync(person, "Admin"); }
            }
            else
            {
                if (isAdmin) { await _userManager.RemoveFromRoleAsync(person, "Admin"); }
            }
            return RedirectToAction("Role");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser()
        {
            var model = new DeleteUserViewModel { Persons = await _person.GetAll() };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var model = await _userManager.FindByIdAsync(id);
            model.IsDeleted = true;
            await _userManager.UpdateAsync(model);

            return RedirectToAction("DeleteUser");
        }
    }
}