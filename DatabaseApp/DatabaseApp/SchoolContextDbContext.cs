using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace DatabaseApp
{
    public class SchoolContextDbContext: DbContext
    {
        public SchoolContextDbContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}

