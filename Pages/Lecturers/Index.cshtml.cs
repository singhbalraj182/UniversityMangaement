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
    public class IndexModel : PageModel
    {
        private readonly UniversityMangaement.Data.UniversityMangaementContext _context;

        public IndexModel(UniversityMangaement.Data.UniversityMangaementContext context)
        {
            _context = context;
        }

        public IList<Lecturer> Lecturer { get;set; }

        public async Task OnGetAsync()
        {
            Lecturer = await _context.Lecturer.ToListAsync();
        }
    }
}
