﻿using StudentsInformationSystem.Models;
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
        public void CreateStudent(string name, string lastName, int depId)
        {
            var student = new Student(name, lastName, depId);
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
        public List<Student> StudentsSameDepartment(int depId)
            {
                return _repository.GetAllSameDepartmentStudents(depId);
            }
        public void AssignLectureToDepartment(int depId, int lecId)
        {
            var departament = _repository.GetDepartmentWithLectures(depId);
            var newAssign = _repository.GetLectureById(lecId);
            departament.Lectures.Add(newAssign);
            _repository.UpdateDepartment(departament);
            _repository.SaveChanges();
        }
        public void AssignLectureToStudent(int stuId, int lecId)
        {
            var student = _repository.GetStudentWithLectures(stuId);
            var newAssign = _repository.GetLectureById(lecId);
            student.Lectures.Add(newAssign);
            _repository.UpdateStudent(student);
            _repository.SaveChanges();
        }
        public void AssignStudentToDepartment(int depId, int stuId)
        {
            var department = _repository.GetDepartmentWithLectures(depId);
            var newAssign = _repository.GetStudentsById(stuId);
            department.Students.Add(newAssign);
            _repository.UpdateDepartment(department);
            _repository.SaveChanges();
        }
        public void CreateDepartmentWithStudentsAndLectures(string name, int lecId, int stuId)
        {
            var department = new Department(name);
            _repository.AddDepartment(department);
            var newLecture = _repository.GetLectureById(lecId);
            var newStudent = _repository.GetStudentsById(stuId);
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
        public void CreateStudentAddLecturesAndDepartment(string name, string lastName, int depId, int lecId)
        {
            var student = new Student(name, lastName, depId);
            _repository.AddStudent(student);
            var newDepartment = _repository.GetDepartmentById(depId);
            var newLecture = _repository.GetLectureById(lecId);
            student.Department = newDepartment;
            student.Lectures.Add(newLecture);
            _repository.SaveChanges();
        }
        public void MoveStudent(int stuId, int depId)
        {
            var newStudent = _repository.GetStudentsById(stuId);
            var newDepartment = _repository.GetDepartmentById(depId);
            newStudent.Department = newDepartment;
            _repository.SaveChanges();
        }
        public void LecturesFromSameDepartment(int depId)
        {
            Department department = _repository.GetDepartmentById(depId);

            foreach (var lecture in _repository.RetrieveLectures())
            {
                if (lecture.Departments.Contains(department))
                {
                    Console.WriteLine($"{lecture.Id}, {lecture.Name}");
                }
            }
        }
        public void LecturesFromSameStudent(int stuId)
        {
            Student student = _repository.GetStudentsById(stuId);
            foreach (var lecture in _repository.RetrieveLectures())
            {
                if (lecture.Students.Contains(student))
                {
                    Console.WriteLine($"{lecture.Id}, {lecture.Name}");
                }
            }
        }
    }

    } 
