using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInformationSystem.Models
{
    public class Lecture
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }

        public Lecture() { }
        public Lecture(string name)
        { 
            Name = name;
            Departments = new List<Department>();
            Students = new List<Student>();
            
        }
    }
}
