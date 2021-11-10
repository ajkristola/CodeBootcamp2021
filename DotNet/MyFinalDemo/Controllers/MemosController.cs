﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinalDemo.Data;
using MyFinalDemo.Models;

namespace MyFinalDemo.Controllers
{
    public class MemosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MemosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Memos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Memo.ToListAsync());
        }

        // GET: Memos/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        // POST: Memos/ShowSearchResults
        // Copied entire list from Index method. Added Where to filter.
        public async Task<IActionResult> ShowSearchResults(string SearchPhrase)
        {
            return View("Index", await _context.Memo.Where( m => m.MemoQuestion.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Memos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memos = await _context.Memo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memos == null)
            {
                return NotFound();
            }

            return View(memos);
        }

        // GET: Memos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Memos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MemoQuestion,MemoAnswer")] Memos memos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memos);
        }

        // GET: Memos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memos = await _context.Memo.FindAsync(id);
            if (memos == null)
            {
                return NotFound();
            }
            return View(memos);
        }

        // POST: Memos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MemoQuestion,MemoAnswer")] Memos memos)
        {
            if (id != memos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemosExists(memos.Id))
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
            return View(memos);
        }

        // GET: Memos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memos = await _context.Memo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memos == null)
            {
                return NotFound();
            }

            return View(memos);
        }

        // POST: Memos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memos = await _context.Memo.FindAsync(id);
            _context.Memo.Remove(memos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemosExists(int id)
        {
            return _context.Memo.Any(e => e.Id == id);
        }
    }
}