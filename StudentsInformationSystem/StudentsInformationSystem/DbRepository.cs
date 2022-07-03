using Microsoft.EntityFrameworkCore;
using StudentsInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInformationSystem
{
    internal class DbRepository
    {
        private readonly StudentsInformationSystemDbContext _dbContext;
        public DbRepository()
        { 
        _dbContext = new StudentsInformationSystemDbContext();
        }
        public void AddDepartment(Department department)
        { 
        _dbContext.Departments.Add(department);
        }
        public void AddLecture(Lecture lecture)
        {
         _dbContext.Lectures.Add(lecture);
        }
        public void AddStudent(Student student)
        { 
        _dbContext.Students.Add(student);
        }
        public Department GetDepartmentById(int id)
        {
            return _dbContext.Departments.FirstOrDefault(x => x.Id == id);
        }
        public Lecture GetLectureById(int id)
        { 
        return _dbContext.Lectures.FirstOrDefault(x => x.Id == id);
        }
        public Student GetStudentsById(int id)
        { 
        return _dbContext.Students.FirstOrDefault(x => x.Id == id);
        }
        public void SaveChanges()
        { 
        _dbContext.SaveChanges();   
        }
        public List<Department> GetAllDepartmentsOrdered()
        {
            var depar = _dbContext.Departments.OrderBy(x=>x.Id).ToList();
            foreach (var department in depar)
            {
                Console.WriteLine($"\n{department.Id} - {department.Name}\n");
            }
            return depar;
        }
        public List<Lecture> GetAllLecturesOrdered()
        { 
        var lectur = _dbContext.Lectures.OrderBy(x=>x.Id).ToList();
            foreach (var lecture in lectur)
            {
                Console.WriteLine($"\n{lecture.Id} - {lecture.Name}\n");
            }
            return lectur;
        }
        public List<Student> GetAllSameDepartmentStudents(int departmentId)
        { 
        return _dbContext.Students.OrderBy(x=>x.Id).ToList().Where(y=>y.DepartmentId== departmentId).ToList();  
        }
        public Department GetDepartment(int id)
        {
            return _dbContext.Departments.Include(x => x.Lectures).FirstOrDefault(y => y.Id == id);
        }
        public void UpdateDepartment(Department department)
        { 
        _dbContext.Attach(department);
        }

    }
}
