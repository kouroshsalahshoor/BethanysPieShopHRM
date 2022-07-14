using BethanysPieShopHRM.Api.Models;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_employeeRepository.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(_employeeRepository.GetEmployeeById(id));
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            if (employee == null)
                return BadRequest();

            if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdEmployee = _employeeRepository.AddEmployee(employee);

            return Created("employee", createdEmployee);
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            if (employee == null)
                return BadRequest();

            if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employeeToUpdate = _employeeRepository.GetEmployeeById(employee.EmployeeId);

            if (employeeToUpdate == null)
                return NotFound();

            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.BirthDate = employee.BirthDate;
            employeeToUpdate.PhoneNumber = employee.PhoneNumber;
            employeeToUpdate.Comment = employee.Comment;
            employeeToUpdate.CountryId = employee.CountryId;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.JoinedDate = employee.JoinedDate;
            employeeToUpdate.ExitDate = employee.ExitDate;
            employeeToUpdate.JobCategoryId = employee.JobCategoryId;
            employeeToUpdate.City = employee.City;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Latitude = employee.Latitude;
            employeeToUpdate.Longitude = employee.Longitude;
            employeeToUpdate.MaritalStatus = employee.MaritalStatus;
            employeeToUpdate.Zip = employee.Zip;
            employeeToUpdate.Street = employee.Street;
            employeeToUpdate.Smoker = employee.Smoker;

            _employeeRepository.UpdateEmployee(employeeToUpdate);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id == 0)
                return BadRequest();

            var employeeToDelete = _employeeRepository.GetEmployeeById(id);
            if (employeeToDelete == null)
                return NotFound();

            _employeeRepository.DeleteEmployee(id);

            return NoContent();//success
        }
    }
}
