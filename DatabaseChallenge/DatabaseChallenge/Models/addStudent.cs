using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseChallenge.Models
{
    public class addStudent
    {
        
    class Program
        {
            static void Main(string[] args)
            {

                using (var ctx = new SchoolContext())
                {
                    var stud = new Student() { StudentName = "Alan" };

                    ctx.Students.Add(stud);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
