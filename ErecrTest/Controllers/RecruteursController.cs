using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ErecrTest.DATA;
using ErecrTest.Models;

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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruteur = await _context.Recruteurs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recruteur == null)
            {
                return NotFound();
            }

            return View(recruteur);
        }

        // GET: Recruteurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recruteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nom,Tel,Email")] Recruteur recruteur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recruteur);
                _context.SaveChanges();
                return RedirectToAction("Recruteurs");
            }
            return View(recruteur);
        }

        // GET: Recruteurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruteur = await _context.Recruteurs.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Tel,Email")] Recruteur recruteur)
        {
            if (id != recruteur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recruteur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecruteurExists(recruteur.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Recruteurs");
            }
            return View(recruteur);
        }

        // GET: Recruteurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recruteur = await _context.Recruteurs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recruteur == null)
            {
                return NotFound();
            }

            return View(recruteur);
        }

        // POST: Recruteurs/Delete/5
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
            return _context.Recruteurs.Any(e => e.Id == id);
        }
    }
}
