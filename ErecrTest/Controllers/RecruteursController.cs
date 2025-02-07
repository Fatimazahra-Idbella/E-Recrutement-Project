using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ErecrTest.DATA;
using ErecrTest.Models;
using Microsoft.AspNetCore.Authorization;

namespace ErecrTest.Controllers
{
    public class RecruteursController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecruteursController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recruteurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recruteurs.ToListAsync());
        }

        // GET: Recruteurs/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruteur = await _context.Recruteurs
                .FirstOrDefaultAsync(m => m.RecruteurId == id);
            if (recruteur == null)
            {
                return NotFound();
            }

            return View(recruteur);
        }

        // GET: Recruteurs/Create
        [Authorize]
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Recruteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Recruteur recruteur)
        {
           _context.Recruteurs.Add(recruteur);
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
              
            

        // GET: Recruteurs/Edit/5
        [Authorize]

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Recruteur recruteur = _context.Recruteurs.Find(id);
            if (recruteur == null)
            {
                return NotFound();
            }
            return View(recruteur);
        }

        // POST: Recruteurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public IActionResult Edit(Recruteur recruteur)
        {

            if (ModelState.IsValid)
            {

                _context.Recruteurs.Update(recruteur);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }




        // GET: Recruteurs/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruteur = await _context.Recruteurs
                .FirstOrDefaultAsync(m => m.RecruteurId == id);
            if (recruteur == null)
            {
                return NotFound();
            }

            return View(recruteur);
        }

        // POST: Recruteurs/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recruteur = await _context.Recruteurs.FindAsync(id);
            if (recruteur != null)
            {
                _context.Recruteurs.Remove(recruteur);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecruteurExists(int id)
        {
            return _context.Recruteurs.Any(e => e.RecruteurId == id);
        }
        [Authorize]
        public IActionResult Statistics()
        {
            var recruiterId = 1; // Replace with actual logged-in recruiter ID

            var recruiter = _context.Recruteurs
                .Include(r => r.Offres)
                .ThenInclude(o => o.Candidatures)
                .FirstOrDefault(r => r.RecruteurId == recruiterId);

            if (recruiter == null)
            {
                return NotFound();
            }

            var totalOffers = recruiter.Offres.Count;
            var totalApplications = recruiter.Offres.Sum(o => o.Candidatures.Count);
            var averageApplicationsPerOffer = totalOffers > 0 ? totalApplications / (double)totalOffers : 0;

            var model = new RecruiterStatisticsViewModel
            {
                TotalOffers = totalOffers,
                TotalApplications = totalApplications,
                AverageApplicationsPerOffer = averageApplicationsPerOffer
            };

            return View(model);
        }

    }
}
