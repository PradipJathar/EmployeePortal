using EmployeePortalWeb.Data;
using EmployeePortalWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortalWeb.Repository
{
    public class EmployeeRepository
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this.db = context;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee employee)
        {
            await db.Employees.AddAsync(employee);
            await db.SaveChangesAsync();
        }
    }
}
