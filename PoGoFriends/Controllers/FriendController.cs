using Microsoft.AspNetCore.Mvc;
using PoGoFriends.Data;
using PoGoFriends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGoFriends.Controllers
{
    public class FriendController : Controller
    {

        private readonly ApplicationDbContext _db;

        public FriendController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Friends> objList = _db.Friends;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Friends friend)
        {
           if(ModelState.IsValid)
            {
                _db.Add(friend);
                _db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(friend);
        }

    }
}
