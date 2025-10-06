using Microsoft.AspNetCore.Mvc;
using TestingPlatform1;
using TestingPlatform1.Models;

namespace TestingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // базовый маршрут: /api/students
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext db) 
        {
            _db = db;

        }

        [HttpGet]
        public IActionResult GetAllStudents() 
        {
           var students = _db.Students.ToList();                    
           
           return Ok(students);
        }   
                             
                    
        
        [HttpGet("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            if (id <= 0)
                return BadRequest("Некорретный id"); //400
            var students = _db.Students.FirstOrDefault(s  => s.Id == id);
            if (students is null)
                return NotFound();
            return Ok(students);
           
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            var emailExists = _db.Students.Where(s => s.Email == student.Email).ToList();
            if (emailExists.Any())
                return Conflict("Такой email уже используется");

            _db.Students.Add(student);
            _db.SaveChanges();

           return Created();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateStudent([FromRoute] int id, [FromBody] Student student)

        {

            if (id != student.Id)
                    return BadRequest("id в пути и в теле запроса не совпадают");

                if (id <= 0)
                    return BadRequest("Некорректный id");

                var exists = _db.Students.Any(s => s.Id == id);
                if (!exists)
                    return NotFound();

                var emailExists = _db.Students.FirstOrDefault(s => s.Email == student.Email && s.Id != id);
                if (emailExists is not null)
                    return Conflict("Такой email уже используется"); //409

                _db.Students.Update(student);
                _db.SaveChanges();

                return NoContent();

        }

            [HttpDelete("{id:int}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _db.Students.Find(id);
            if (student is null)
                return NotFound();

            _db.Students.Remove(student);
            _db.SaveChanges();

            return NoContent();
        }

    }
}
