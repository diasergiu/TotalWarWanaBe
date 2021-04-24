using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TotalWarWanaBe.DAL;
using TotalWarWanaBe.Domain.Entityes;

namespace TotalWarWanaBe.Web.Controllers
{
    public class FactionsController : Controller
    {
        private TotalWarWanaBeDbContext _context;
        public FactionsController(TotalWarWanaBeDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Factions.ToList());
        }
        [HttpGet]
        public IActionResult CreateFaction()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFaction(Faction faction)
        {
            if (ModelState.IsValid)
            {
                _context.Factions.Add(faction);
                _context.SaveChanges();
                return RedirectToAction("CreateFaction");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditFaction(int id)
        {
            return View(_context.Factions.Where(f => f.IdFaction == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult EditFaction(Faction editedFaction)
        {
            if (ModelState.IsValid)
            {
                _context.Factions.Update(editedFaction);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            // need a pop up to know that the edit didnt work
            return RedirectToAction("EditFaction");
        }

        [HttpGet]
        public IActionResult DeleteFaction(int id)
        {
            return View(_context.Factions.Where(f => f.IdFaction == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteFaction(Faction deleteFaction)
        {
            if (ModelState.IsValid)
            {
                _context.Factions.Remove(_context.Factions.Where(f => f.IdFaction == deleteFaction.IdFaction).FirstOrDefault());
                _context.SaveChanges();
            }
            // also need to send a pop up if the delete didnt work
            return RedirectToAction("Index");
        }
    }
}
