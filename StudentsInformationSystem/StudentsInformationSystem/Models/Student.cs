using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInformationSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        //public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public List<Lecture> Lectures { get; set; }

        public Student() { }
        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            Lectures = new List<Lecture>();
        }   
    }
}
