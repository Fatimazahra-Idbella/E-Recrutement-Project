using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ErecrTest.DATA;
using ErecrTest.Models;
using Microsoft.AspNetCore.Identity;

namespace ErecrTest.Controllers
{
    public class OffresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OffresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Offres
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Offres.Include(o => o.Recruteur);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Offres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offre = await _context.Offres
                .Include(o => o.Recruteur)
                .FirstOrDefaultAsync(m => m.OffreId == id);
            if (offre == null)
            {
                return NotFound();
            }

            return View(offre);
        }

        // GET: Offres/Create
        public IActionResult Create()
        {
          
            return View();
        }

        // POST: Offres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Offre offre)
        {
              if (ModelState.IsValid)
            {
                
                offre.Candidatures = new List<Candidature>(); // Assurez-vous que ce champ est initialisé

                _context.Offres.Add(offre);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(offre);
      
           
        }

        // GET: Offres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offre = await _context.Offres.FindAsync(id);
            if (offre == null)
            {
                return NotFound();
            }
            ViewData["RecruteurId"] = new SelectList(_context.Recruteurs, "Id", "Id", offre.RecruteurId);
            return View(offre);
        }

        // POST: Offres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RecruteurId,TypeContrat,Secteur,Profil,Poste,Remuneration")] Offre offre)
        {
            if (id != offre.RecruteurId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OffreExists(offre.OffreId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RecruteurId"] = new SelectList(_context.Recruteurs, "Id", "Id", offre.RecruteurId);
            return View(offre);
        }

        // GET: Offres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offre = await _context.Offres
                .Include(o => o.Recruteur)
                .FirstOrDefaultAsync(m => m.RecruteurId == id);
            if (offre == null)
            {
                return NotFound();
            }

            return View(offre);
        }

        // POST: Offres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offre = await _context.Offres.FindAsync(id);
            if (offre != null)
            {
                _context.Offres.Remove(offre);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OffreExists(int id)
        {
            return _context.Offres.Any(e => e.OffreId == id);

        }
            // Action pour afficher la liste des offres avec la possibilité de filtrer
            public IActionResult Listeoffres(string secteur, string profil, decimal? minRemuneration, decimal? maxRemuneration)
            {
                // Filtrer les offres selon les critères de recherche
                var offres = _context.Offres.AsQueryable();

                if (!string.IsNullOrEmpty(secteur))
                {
                    offres = offres.Where(o => o.Secteur.Contains(secteur));
                }

                if (!string.IsNullOrEmpty(profil))
                {
                    offres = offres.Where(o => o.Profil.Contains(profil));
                }

                if (minRemuneration.HasValue)
                {
                    offres = offres.Where(o => o.Remuneration >= minRemuneration.Value);
                }

                if (maxRemuneration.HasValue)
                {
                    offres = offres.Where(o => o.Remuneration <= maxRemuneration.Value);
                }

                // Retourner la liste des offres filtrées
                return View(offres.ToList());
            }
        }

    }
    

