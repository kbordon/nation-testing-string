using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NationBuilder.Models;

namespace NationBuilder.Controllers
{
    [Authorize]
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
    }
}
