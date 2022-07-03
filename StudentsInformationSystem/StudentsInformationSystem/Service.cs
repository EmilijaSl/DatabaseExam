using StudentsInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInformationSystem
{
    internal class Service
    {
        private readonly DbRepository _repository;
        public Service()
        {
            _repository = new DbRepository();
        }
        public void CreateDepartment(string name)
        {
            var department = new Department(name);
            _repository.AddDepartment(department);
            _repository.SaveChanges();
        }
        public void CreateLecture(string name)
        {
            var lecture = new Lecture(name);
            _repository.AddLecture(lecture);
            _repository.SaveChanges();
        }
        public void CreateStudent(string name, string lastName, int departmentId)
        {
            var student = new Student(name, lastName, departmentId);
            _repository.AddStudent(student);
            _repository.SaveChanges();
        }
        public List<Department> GetDepartments()
        {
            return _repository.GetAllDepartmentsOrdered();
        }
        public List<Lecture> GetLectures()
        {
            return _repository.GetAllLecturesOrdered();
        }
        public List<Student> StudentsSameDepartment(int departmentId)
            {
                return _repository.GetAllSameDepartmentStudents(departmentId);
            }
        public void AssignLectureToDepartment(int depId, int lectureId)
        {
            var departament = _repository.GetDepartment(depId);
            var newAssign = _repository.GetLectureById(lectureId);
            departament.Lectures.Add(newAssign);
            _repository.UpdateDepartment(departament);
            _repository.SaveChanges();
        }
        }

    } 
