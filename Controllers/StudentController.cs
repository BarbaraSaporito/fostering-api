using FosteringAPI.Data;
using FosteringAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FosteringAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly FosteringContext _context;

        public StudentController(FosteringContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/students")]
        public async Task<ActionResult> GetStudents()
        {
            return Ok(await _context.Students.ToListAsync());
        }

        [HttpPost]
        [Route("/students")]
        public async Task<ActionResult> CreateStudent(Student student)
        {
            await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync();  

            return Ok(student); 
        }


        [HttpPut]
        [Route("/students")]
        public async Task<ActionResult> UpdateStudent(Student student)
        {
            var dbStudent = await _context.Students.FindAsync(student.Id);
            if (dbStudent == null) return NotFound();

            dbStudent.Name = student.Name;
            dbStudent.Phone = student.Phone;
            dbStudent.Course = student.Course;
            dbStudent.Period = student.Period;
            dbStudent.Hobby = student.Hobby;
            dbStudent.Sentence = student.Sentence;

            await _context.SaveChangesAsync();

            return Ok(student);
        }

        [HttpDelete]
        [Route("/students")]
        public async Task<ActionResult> DeleteStudent(Guid id)
        {
            var dbStudent = await _context.Students.FindAsync(id);

            if (dbStudent == null) return NotFound();

            _context.Students.Remove(dbStudent);    

            await _context.SaveChangesAsync();

            return NoContent();
                
        }
    }
}

