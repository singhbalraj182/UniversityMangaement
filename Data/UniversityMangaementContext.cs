using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityMangaement.Models;

namespace UniversityMangaement.Data
{
    public class UniversityMangaementContext : DbContext
    {
        public UniversityMangaementContext (DbContextOptions<UniversityMangaementContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityMangaement.Models.Department> Department { get; set; }

        public DbSet<UniversityMangaement.Models.Lecturer> Lecturer { get; set; }

        public DbSet<UniversityMangaement.Models.Module> Module { get; set; }

        public DbSet<UniversityMangaement.Models.Service> Service { get; set; }
    }
}
