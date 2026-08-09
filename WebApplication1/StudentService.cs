using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class StudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
       _students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "John",
                Email = "john@example.com"
            },
            new Student
            {
                Id = 2,
                Name = "David",
                Email = "david@example.com"
            }
        };
        }



        public List<Student> GetAll()
        {
            return _students;
        }
    }
}