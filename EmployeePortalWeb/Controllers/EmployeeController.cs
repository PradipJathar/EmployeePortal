using EmployeePortalWeb.Models;
using EmployeePortalWeb.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortalWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository repo;

        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this.repo = employeeRepository;
        }


        [HttpGet]
        public async Task<ActionResult> EmployeeList()
        {
            var allEmployees = await repo.GetEmployeesAsync();
            return Ok(allEmployees);
        }

        [HttpPost]
        public async Task<ActionResult> SaveEmployee(Employee employee)
        {
            await repo.SaveEmployee(employee);
            return Ok(employee);
        }
    }
}
