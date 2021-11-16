using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManterCurso15_11.Model;

    public class ManterCurso15_11Context : DbContext
    {
        public ManterCurso15_11Context (DbContextOptions<ManterCurso15_11Context> options)
            : base(options)
        {
        }

        public DbSet<ManterCurso15_11.Model.Categoria> Categoria { get; set; }

        public DbSet<ManterCurso15_11.Model.Curso> Curso { get; set; }

        public DbSet<ManterCurso15_11.Model.Log> Log { get; set; }
    }
