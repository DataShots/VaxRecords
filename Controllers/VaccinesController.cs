using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VaxRecords.Models;

namespace VaxRecords.Controllers
{
    public class VaccinesController : Controller
    {
        private readonly VaccinationRecordContext _context;

        public VaccinesController(VaccinationRecordContext context)
        {
            _context = context;
        }

        // GET: Vaccines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vaccines.ToListAsync());
        }

        // GET: Vaccines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccines = await _context.Vaccines
                .FirstOrDefaultAsync(m => m.VaccineId == id);
            if (vaccines == null)
            {
                return NotFound();
            }

            return View(vaccines);
        }

        // GET: Vaccines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaccines/Create
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VaccineId,Vaccine,Date,Dose,Method,Clinician,Notes")] Vaccines vaccines)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccines);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccines);
        }

        // GET: Vaccines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccines = await _context.Vaccines.FindAsync(id);
            if (vaccines == null)
            {
                return NotFound();
            }
            return View(vaccines);
        }

        // POST: Vaccines/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VaccineId,Vaccine,Date,Dose,Method,Clinician,Notes")] Vaccines vaccines)
        {
            if (id != vaccines.VaccineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaccines);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaccinesExists(vaccines.VaccineId))
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
            return View(vaccines);
        }

        // GET: Vaccines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccines = await _context.Vaccines
                .FirstOrDefaultAsync(m => m.VaccineId == id);
            if (vaccines == null)
            {
                return NotFound();
            }

            return View(vaccines);
        }

        // POST: Vaccines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaccines = await _context.Vaccines.FindAsync(id);
            _context.Vaccines.Remove(vaccines);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaccinesExists(int id)
        {
            return _context.Vaccines.Any(e => e.VaccineId == id);
        }
    }
}
