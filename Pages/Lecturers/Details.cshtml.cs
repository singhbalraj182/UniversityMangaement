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
    public class DetailsModel : PageModel
    {
        private readonly UniversityMangaement.Data.UniversityMangaementContext _context;

        public DetailsModel(UniversityMangaement.Data.UniversityMangaementContext context)
        {
            _context = context;
        }

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
    }
}
