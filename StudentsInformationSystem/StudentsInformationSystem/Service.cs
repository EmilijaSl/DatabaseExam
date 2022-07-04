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
        public List<Student> GetStudents()
        { 
        return _repository.GetAllStudentsOrdered();
        }
        public List<Student> StudentsSameDepartment(int departmentId)
            {
                return _repository.GetAllSameDepartmentStudents(departmentId);
            }
        public void AssignLectureToDepartment(int depId, int lectureId)
        {
            var departament = _repository.GetDepartmentWithLectures(depId);
            var newAssign = _repository.GetLectureById(lectureId);
            departament.Lectures.Add(newAssign);
            _repository.UpdateDepartment(departament);
            _repository.SaveChanges();
        }
        public void AssignStudentToDepartment(int depId, int studentId)
        {
            var department = _repository.GetDepartmentWithLectures(depId);
            var newAssign = _repository.GetStudentsById(studentId);
            department.Students.Add(newAssign);
            _repository.UpdateDepartment(department);
            _repository.SaveChanges();
        }
        public void CreateDepartmentWithStudentsAndLectures(string name, int lectureId, int studentId)
        {
            var department = new Department(name);
            _repository.AddDepartment(department);
            var newLecture = _repository.GetLectureById(lectureId);
            var newStudent = _repository.GetStudentsById(studentId);
            department.Lectures.Add(newLecture);
            department.Students.Add(newStudent);
            _repository.SaveChanges();
        }
        public void CreateLectureAndAssignToDepartment(string name, int depId)
        {
            var lecture = new Lecture(name);
            _repository.AddLecture(lecture);
            var newDepartment = _repository.GetDepartmentById(depId);
            lecture.Departments.Add(newDepartment);
            _repository.SaveChanges();
        }
        public void CreateStudentAddLecturesAndDepartment(string name, string lastName, int departmentId, int lectureId)
        {
            var student = new Student(name, lastName, departmentId);
            _repository.AddStudent(student);
            var newDepartment = _repository.GetDepartmentById(departmentId);
            var newLecture = _repository.GetLectureById(lectureId);
            student.Department = newDepartment;
            student.Lectures.Add(newLecture);
            _repository.SaveChanges();
        }
        public void MoveStudent(int studentId, int departmentId)
        {
            var newStudent = _repository.GetStudentsById(studentId);
            var newDepartment = _repository.GetDepartmentById(departmentId);
            newStudent.Department = newDepartment;
            _repository.SaveChanges();
        }
       

    }

    } 
