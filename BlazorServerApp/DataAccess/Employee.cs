using System;

namespace DataAccess
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public Department Department { get; set; }
    }

    public enum Department
    {
        IT,
        HR,
        Finance
    }
}