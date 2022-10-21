using CommunicationApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using CommunicationApp.Services;

namespace CommunicationApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Person> _userManager;
        private SmsService _smsService;

        public HomeController(RoleManager<IdentityRole> roleManager, UserManager<Person> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _smsService = new SmsService();
        }

        public async Task<IActionResult> Index()
        {
            
            ViewData["Title"] = "Startsida";
            if (User.Identity.IsAuthenticated)
            {
                // Rollen "Admin" skapas om den inte finns. 
                if (!await _roleManager.RoleExistsAsync("Admin"))
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                    Console.WriteLine("Admin är tillagd i databasen.");
                }
                // Om ingen användare har rollen "admin" så tilldelas inloggad användare den behörigheten.
                if (_userManager.GetUsersInRoleAsync("Admin").Result.Count == 0)
                {
                    await _userManager.AddToRoleAsync(await _userManager.GetUserAsync(User), "Admin");
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Integritetspolicy";
            return View();
        }

        public IActionResult Support()
        {
            ViewData["Title"] = "Support";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}