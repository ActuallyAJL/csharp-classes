using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company nnvh = new Company("Nineveh Productions", DateTime.Now);

            // Create three employees
            Employee Carl = new Employee("Carl", "Stafford", "Paper Wrangler", DateTime.Now);
            Employee Dave = new Employee("Dave", "Baxter", "Lord of Purchasing", DateTime.Now);
            Employee Stacy = new Employee("Stacy", "Escher", "TimeClock Witch", DateTime.Now);

            // Assign the employees to the company

            nnvh.Employees.Add(Carl);
            nnvh.Employees.Add(Dave);
            nnvh.Employees.Add(Stacy);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            nnvh.ListEmployees();
        }
    }
}