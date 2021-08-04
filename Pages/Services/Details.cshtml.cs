using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UniversityMangaement.Data;
using UniversityMangaement.Models;

namespace UniversityMangaement.Pages.Services
{
    public class DetailsModel : PageModel
    {
        private readonly UniversityMangaement.Data.UniversityMangaementContext _context;

        public DetailsModel(UniversityMangaement.Data.UniversityMangaementContext context)
        {
            _context = context;
        }

        public Service Service { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Service = await _context.Service
                .Include(s => s.Department)
                .Include(s => s.Lecturer)
                .Include(s => s.Module).FirstOrDefaultAsync(m => m.Id == id);

            if (Service == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
