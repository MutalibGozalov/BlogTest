using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RNET102.UI.Data;
using RNET102.UI.Models;

namespace RNET102.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {
        private readonly RNET102DbContext _context;

        public BlogsController(RNET102DbContext context)
        {
            _context = context;
        }

        // GET: Admin/Blogss
        public async Task<IActionResult> Index()
        {
              return _context.Blogs != null ? 
                          View(await _context.Blogs.ToListAsync()) :
                          Problem("Entity set 'RNET102DbContext.Blogs'  is null.");
        }

        // GET: Admin/Blogss/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Blogs == null)
            {
                return NotFound();
            }

            var Blogs = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Blogs == null)
            {
                return NotFound();
            }

            return View(Blogs);
        }

        // GET: Admin/Blogss/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Blogss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImageURL,PublishDate,Title,Content")] Blog Blogs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Blogs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Blogs);
        }

        // GET: Admin/Blogss/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Blogs == null)
            {
                return NotFound();
            }

            var Blog = await _context.Blogs.FindAsync(id);
            if (Blog == null)
            {
                return NotFound();
            }
            return View(Blog);
        }

        // POST: Admin/Blogss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageURL,PublishDate,Title,Content")] Blog Blogs)
        {
            if (id != Blogs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Blogs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogsExists(Blogs.Id))
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
            return View(Blogs);
        }

        // GET: Admin/Blogss/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Blogs == null)
            {
                return NotFound();
            }

            var Blogs = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Blogs == null)
            {
                return NotFound();
            }

            return View(Blogs);
        }

        // POST: Admin/Blogss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Blogs == null)
            {
                return Problem("Entity set 'RNET102DbContext.Blogs'  is null.");
            }
            var Blogs = await _context.Blogs.FindAsync(id);
            if (Blogs != null)
            {
                _context.Blogs.Remove(Blogs);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogsExists(int id)
        {
          return (_context.Blogs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
