using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InfiniteDraws_Creations.Data;
using InfiniteDraws_Creations.Models;

namespace InfiniteDraws_Creations.Controllers
{
    public class DrawersController : Controller
    {
        private readonly InfiniteDraws_CreationsContext _context;

        public DrawersController(InfiniteDraws_CreationsContext context)
        {
            _context = context;
        }

        // GET: Drawers
        public async Task<IActionResult> Index(string drawerType, string searchString)
        {
            if (_context.Drawer == null)
            {
                return Problem("Entity set 'InfiniteDraws_CreationsContext.Movie'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Drawer
                                            orderby m.Type
                                            select m.Type;
            var movies = from m in _context.Drawer
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Type!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(drawerType))
            {
                movies = movies.Where(x => x.Type == drawerType);
            }

            var drawerTypeVM = new DrawerTypeViewModel
            {
                Types = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Drawers = await movies.ToListAsync()
            };

            return View(drawerTypeVM);
        }


        // GET: Drawers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drawer = await _context.Drawer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drawer == null)
            {
                return NotFound();
            }

            return View(drawer);
        }

        // GET: Drawers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drawers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,DrawerMaterial,Color,Price,Rating,Reviews")] Drawer drawer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drawer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drawer);
        }

        // GET: Drawers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drawer = await _context.Drawer.FindAsync(id);
            if (drawer == null)
            {
                return NotFound();
            }
            return View(drawer);
        }

        // POST: Drawers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,DrawerMaterial,Color,Price,Rating,Reviews")] Drawer drawer)
        {
            if (id != drawer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drawer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrawerExists(drawer.Id))
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
            return View(drawer);
        }

        // GET: Drawers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drawer = await _context.Drawer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drawer == null)
            {
                return NotFound();
            }

            return View(drawer);
        }

        // POST: Drawers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drawer = await _context.Drawer.FindAsync(id);
            if (drawer != null)
            {
                _context.Drawer.Remove(drawer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrawerExists(int id)
        {
            return _context.Drawer.Any(e => e.Id == id);
        }
    }
}
