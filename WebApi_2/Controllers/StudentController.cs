using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>();

        // GET: api/Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(stu => stu.Id == id);
        }

        // POST: api/Student
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            students.Add(value);
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            int index = students.FindIndex(stu => stu.Id == id);
            if (index > 0)
                students[index] = value;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(stu => stu.Id == id);
        }
    }
}
