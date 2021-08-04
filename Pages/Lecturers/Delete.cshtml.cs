using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversityMangaement.Data;
using UniversityMangaement.Models;

namespace UniversityMangaement.Pages.Lecturers
{
    public class DeleteModel : PageModel
    {
        private readonly UniversityMangaement.Data.UniversityMangaementContext _context;

        public DeleteModel(UniversityMangaement.Data.UniversityMangaementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lecturer Lecturer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lecturer = await _context.Lecturer.FirstOrDefaultAsync(m => m.Id == id);

            if (Lecturer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lecturer = await _context.Lecturer.FindAsync(id);

            if (Lecturer != null)
            {
                _context.Lecturer.Remove(Lecturer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
