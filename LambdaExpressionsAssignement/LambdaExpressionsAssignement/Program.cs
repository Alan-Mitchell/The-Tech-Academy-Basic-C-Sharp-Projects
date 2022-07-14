using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsAssignement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 2, FirstName = "Joe", LastName = "Turner" });
            EmployeeList.Add(new Employee() { Id = 3, FirstName = "Bessie", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 4, FirstName = "Phil", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 5, FirstName = "Lee", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 6, FirstName = "Dan", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 7, FirstName = "Steve", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 16, FirstName = "Job", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 15, FirstName = "Alan", LastName = "Smith" });
            EmployeeList.Add(new Employee() { Id = 12, FirstName = "Jane", LastName = "Smith" });

            List<Employee> JoeEmployee = new List<Employee>();

            foreach(Employee emp in EmployeeList)
            {
                if (emp.FirstName =="Joe" )
                {
                    JoeEmployee.Add(emp);
                }
               
            }
            foreach(Employee emp in JoeEmployee)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }



            JoeEmployee = (List<Employee>)EmployeeList.Where(x => x.FirstName == "Joe");




            Console.ReadLine();
        }
    }
}
