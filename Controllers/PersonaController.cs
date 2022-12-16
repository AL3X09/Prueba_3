using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_3.Context;
using Prueba_3.Models;

namespace Prueba_3.Controllers
{
    public class PersonaController : Controller
    {
        private readonly Prueba3DbContext _context;

        public PersonaController(Prueba3DbContext context)
        {
            _context = context;
        }

        // GET: Direccion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Persona.ToListAsync());
        }

        // GET: Direccion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personaClass = await _context.Persona
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personaClass == null)
            {
                return NotFound();
            }

            return View(personaClass);
        }

        // GET: Direccion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Direccion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,is_Active")] PersonaClass personaClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personaClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personaClass);
        }

        // GET: Direccion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personaClass = await _context.Persona.FindAsync(id);
            if (personaClass == null)
            {
                return NotFound();
            }
            return View(personaClass);
        }

        // POST: Direccion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Num_identificacion,Nombres,Apellidos,Fecha_nacimiento,Telefono_1,Telefono_2,Correo_electronico,Direccion")] PersonaClass personaClass)
        {
            if (id != personaClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personaClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaClassExists(personaClass.Id))
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
            return View(personaClass);
        }

        // GET: Direccion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personaClass = await _context.Persona
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personaClass == null)
            {
                return NotFound();
            }

            return View(personaClass);
        }

        // POST: Direccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personaClass = await _context.Persona.FindAsync(id);
            _context.Persona.Remove(personaClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaClassExists(int id)
        {
            return _context.Persona.Any(e => e.Id == id);
        }
    }
   
}
