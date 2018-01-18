using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NationBuilder.Models;
using System.Security.Claims;
using NationBuilder.ViewModels;

namespace NationBuilder.Controllers
{
    public class NationController : Controller
    {

        private readonly GameDbContext _db;
        private readonly UserManager<GameUser> _userManager;

        public NationController (UserManager<GameUser> userManager, GameDbContext db)
        {
            _userManager = userManager;
            _db = db; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            CreateViewModel cvm = new CreateViewModel();
            Console.WriteLine("###############################" + CreateViewModel.Governments[5]);
            Dictionary<int, string> test = CreateViewModel.Governments;
            return View("test");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Nation nation)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            nation.User = currentUser;
            _db.Nations.Add(nation);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
