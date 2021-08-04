using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityMangaement.Data;
using UniversityMangaement.Models;

namespace UniversityMangaement.Pages.Lecturers
{
    public class CreateModel : PageModel
    {
        private readonly UniversityMangaement.Data.UniversityMangaementContext _context;

        public CreateModel(UniversityMangaement.Data.UniversityMangaementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lecturer Lecturer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lecturer.Add(Lecturer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
