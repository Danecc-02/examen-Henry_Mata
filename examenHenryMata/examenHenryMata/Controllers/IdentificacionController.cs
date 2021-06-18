using examenHenryMata.Data;
using examenHenryMata.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examenHenryMata.Controllers
{
    public class IdentificacionController : Controller
    {
        private readonly ApplicationDbContext db;

        public IdentificacionController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult>Index(string search)
        {
            if (search==null)
            {
                return View(await db.Identificaciones.ToListAsync());
            }
            return View(await db.Identificaciones.Where(h => h.IdentificacionNombres.Contains(search)).ToListAsync());

        }

        //crear////////////////////////////////////////////////////////

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Identificacion identificac)
        {
            if (ModelState.IsValid)
            {
                db.Add(identificac);
                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(identificac);
        }


        //////////////////////////////////////////////////////////////
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.Identificaciones.FindAsync(id);
            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Identificacion identifi)
        {
            if (id != identifi.IdentificacionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(identifi);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();

                }

                return RedirectToAction(nameof(Index));
            }

            return View(identifi);
        }
        ///////////////////////////////////////////////////////////////////////
        ///

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.Identificaciones.FirstOrDefaultAsync(d => d.IdentificacionId == id);
            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);

        }

        ///////////////////////////////////////////////////////////////////////////

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depart = await db.Identificaciones.FirstOrDefaultAsync(m => m.IdentificacionId == id);

            if (depart == null)
            {
                return NotFound();
            }

            return View(depart);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var depart = await db.Identificaciones.FindAsync(id);
            db.Identificaciones.Remove(depart);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
