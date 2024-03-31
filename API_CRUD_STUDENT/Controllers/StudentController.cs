using API_CRUD_STUDENT.Database;
using API_CRUD_STUDENT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace API_CRUD_STUDENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext studentDbContext;

        public StudentController(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudent()
        {
            var Persons = await studentDbContext.Student.ToListAsync();
            return Ok(Persons);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] Student person)
        {
            person.studentId = Guid.NewGuid();
            await studentDbContext.Student.AddAsync(person);
            await studentDbContext.SaveChangesAsync();
            return Ok(person);
        }

        [HttpPut]
        [Route("{StudentId:guid}")]
        public async Task<IActionResult> UpdateStudent([FromRoute] Guid studentId, [FromBody] Student person)
        {
            var person1 = await studentDbContext.Student.FirstOrDefaultAsync(a => a.studentId == studentId);
            if (person1 != null)
            {
                person1.name = person.name;
                person1.department = person.department;
                person1.gender = person.gender;
                person1.emailId=person.emailId;
                person1.dob=person.dob;

                await studentDbContext.SaveChangesAsync();

                return Ok(person);

            }
            else
            {
                return NotFound("Student List Not Found");
            }

        }

        [HttpDelete]
        [Route("{Studentid:guid}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] Guid studentid)
        {
            var person1 = await studentDbContext.Student.FirstOrDefaultAsync(a => a.studentId == studentid);
            if (person1 != null)
            {
                studentDbContext.Student.Remove(person1);
                return Ok(person1);
            }
            else
            {
                return NotFound("Student list Not Found");
            }

        }
    }
}
