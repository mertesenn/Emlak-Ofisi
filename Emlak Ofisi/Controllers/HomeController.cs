using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emlak_Ofisi.Context;
using Emlak_Ofisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emlak_Ofisi.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmlakDBContext _context;
        public HomeController(EmlakDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(NewUserModel model)
        {
            // Veritabanına User Tablosuna Kayıt edilecek
            User user = new User();
            user.NameSurname = model.CompanyName;
            user.Password = model.Password;
            user.UserName = model.UserName;
            _context.Users.Add(user);
            var result = _context.SaveChanges();
            if (result == 1)
                ViewData["mesaj"] = "Kayıt Başarı ile oluşturuldu.";

            return View();
        }
    }
}