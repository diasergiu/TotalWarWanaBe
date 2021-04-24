using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TotalWarWanaBe.DAL;
using TotalWarWanaBe.Domain.Entityes;
using TotalWarWanaBe.Web.Models;

namespace TotalWarWanaBe.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly TotalWarWanaBeDbContext _context;

        public HomeController(TotalWarWanaBeDbContext db)
        {
            this._context = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public Faction GetFactionById(int id)
        {
            return _context.Factions.Find(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
