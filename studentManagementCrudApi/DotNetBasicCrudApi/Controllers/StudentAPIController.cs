using DotNetBasicCrudApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetBasicCrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly studentsContext context;

        public StudentAPIController(studentsContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetUser()
        {
            var data = await context.Students.ToListAsync();

            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetUserByMobileNumber(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateUser(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateUser(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteUser(int id )
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
