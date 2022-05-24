using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public Employee(string fn, string ln, string t, DateTime sd)
        {
            FirstName = fn;
            LastName = ln;
            Title = t;
            StartDate = sd;
        }
    }
}