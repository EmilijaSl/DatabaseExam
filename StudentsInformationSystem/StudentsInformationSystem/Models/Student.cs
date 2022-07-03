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
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }   
        public Department Department { get; set; }
        public List<Lecture> Lectures { get; set; }

        public Student() { }
        public Student(string name, string lastName, int departmentId)
        {
            Name = name;
            LastName = lastName;
            DepartmentId = departmentId;
            Lectures = new List<Lecture>();
            
        }
    }
}
