﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Plan.Data;
using MVC_Plan.Models;

namespace MVC_Plan.Controllers
{
    public class DegreePlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreePlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreePlans
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {

            ViewData["DegreePlanAbrrevSortParm"] = String.IsNullOrEmpty(sortOrder) ? "degreePlanAbreev_desc" : "";
            ViewData["DegreePlanNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "degreePlanName_desc" : "DegreePlanName";
            ViewData["DegreeSortParm"] = sortOrder == "Degree" ? "degree_desc" : "Degree";
            ViewData["StudentSortParm"] = sortOrder == "Student" ? "student_desc" : "Student";
            ViewData["currentFilter"] = searchString;

            var degreePlans = from s in _context.DegreePlans.Include(d => d.Degree).Include(d => d.Student)
                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                degreePlans = degreePlans.Where(s => s.DegreePlanName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "degreePlanAbreev_desc":
                    degreePlans = degreePlans.OrderByDescending(s => s.DegreePlanAbbrev);
                    break;
                case "DegreePlanName":
                    degreePlans = degreePlans.OrderBy(s => s.DegreePlanName);
                    break;
                case "degreePlanName_desc":
                    degreePlans = degreePlans.OrderByDescending(s => s.DegreePlanName);
                    break;
                case "Degree":
                    degreePlans = degreePlans.OrderBy(s => s.DegreeID);
                    break;
                case "degree_desc":
                    degreePlans = degreePlans.OrderByDescending(s => s.DegreeID);
                    break;
                case "Student":
                    degreePlans = degreePlans.OrderBy(s => s.StudentID);
                    break;
                case "student_desc":
                    degreePlans = degreePlans.OrderByDescending(s => s.StudentID);
                    break;
                default:
                    degreePlans = degreePlans.OrderBy(s => s.DegreePlanAbbrev);
                    break;
            }

            return View(await degreePlans.AsNoTracking().ToListAsync());
        }

        // GET: DegreePlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans
                .FirstOrDefaultAsync(m => m.DegreePlanID == id);
            if (degreePlan == null)
            {
                return NotFound();
            }

            return View(degreePlan);
        }

        // GET: DegreePlans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DegreePlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreePlanID,DegreeID,StudentID,DegreePlanAbbrev,DegreePlanName")] DegreePlan degreePlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreePlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(degreePlan);
        }

        // GET: DegreePlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }
            var studentDegreePlan = await _context.DegreePlans
                .Include(p => p.Degree).ThenInclude(pd => pd.Requirements)
                .Include(p => p.Student)
                .Include(p => p.StudentTerms).ThenInclude(pt => pt.DegreeRequirements)
                .SingleOrDefaultAsync(m => m.DegreePlanID == id);

            if (studentDegreePlan == null) { return NotFound(); }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbrev", studentDegreePlan.DegreeID);
           // ViewData["DegreeStatusId"] = new SelectList(_context.DegreeStatuses, "DegreeStatusId", "Status", studentDegreePlan.DegreeStatusId);
            ViewData["StudentID"] = new SelectList(_context.Students, "StudentId", "GivenName", studentDegreePlan.StudentID);
            return View(studentDegreePlan);
        }

        // POST: DegreePlans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreePlanID,DegreeID,StudentID,DegreePlanAbbrev,DegreePlanName")] DegreePlan degreePlan)
        {
            if (id != degreePlan.DegreePlanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreePlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreePlanExists(degreePlan.DegreePlanID))
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
            return View(degreePlan);
        }

        // GET: DegreePlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans
                .FirstOrDefaultAsync(m => m.DegreePlanID == id);
            if (degreePlan == null)
            {
                return NotFound();
            }

            return View(degreePlan);
        }

        // POST: DegreePlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreePlan = await _context.DegreePlans.FindAsync(id);
            _context.DegreePlans.Remove(degreePlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreePlanExists(int id)
        {
            return _context.DegreePlans.Any(e => e.DegreePlanID == id);
        }
    }
}
