using DataAccess;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            RenderEmployees();
            return base.OnInitializedAsync();
        }

        public void RenderEmployees()
        {
            Employees = new List<Employee>
            {
                new Employee
                {
                    Id=100,
                    Name="Johny Cash",
                    JoiningDate=DateTime.Now.AddDays(-2),
                    Designation="Principal Developer",
                    Department=Department.IT
                },
                new Employee
                {
                    Id=101,
                    Name="John Doe",
                    JoiningDate=DateTime.Now.AddYears(-2),
                    Designation="Senior Developer",
                    Department=Department.IT
                },
                new Employee
                {
                    Id=102,
                    Name="Mary Dory",
                    JoiningDate=DateTime.Now.AddYears(-1),
                    Designation="Senior Developer Advocate",
                    Department=Department.IT
                },
                new Employee
                {
                    Id=103,
                    Name="Lisa Ann",
                    JoiningDate=DateTime.Now.AddYears(-3),
                    Designation="Senior HR",
                    Department=Department.HR
                },
                new Employee
                {
                    Id=105,
                    Name="Martin Jose",
                    JoiningDate=DateTime.Now.AddMonths(-2),
                    Designation="Chartered Accountant",
                    Department=Department.Finance
                }
            };
        }
    }
}