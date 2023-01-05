using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Devs2Blu.ProjetoFinalDeAno.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;

namespace Devs2Blu.ProjetoFinalDeAno.Controllers
{
    public class ImagensController : Controller
    {
        private readonly ContextoDatabase _context;

        public ImagensController(ContextoDatabase context)
        {
            _context = context;
        }

        // GET: Imagems
        public async Task<IActionResult> Index()
        {
            return View(await _context.Imagem.ToListAsync());
        }

        // GET: Imagems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Imagem == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imagem == null)
            {
                return NotFound();
            }

            return View(imagem);
        }

        // GET: Imagems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imagems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EnderecoImagem,IdPizza")] Imagem imagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imagem);
        }

        // GET: Imagems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Imagem == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem.FindAsync(id);
            if (imagem == null)
            {
                return NotFound();
            }
            return View(imagem);
        }

        // POST: Imagems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EnderecoImagem,IdPizza")] Imagem imagem)
        {
            if (id != imagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagemExists(imagem.Id))
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
            return View(imagem);
        }

        // GET: Imagems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Imagem == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imagem == null)
            {
                return NotFound();
            }

            return View(imagem);
        }

        // POST: Imagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Imagem == null)
            {
                return Problem("Entity set 'ContextoDatabase.Imagem'  is null.");
            }
            var imagem = await _context.Imagem.FindAsync(id);
            if (imagem != null)
            {
                _context.Imagem.Remove(imagem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagemExists(int id)
        {
            return _context.Imagem.Any(e => e.Id == id);
        }
    }
}
