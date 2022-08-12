using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContextDbContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}


