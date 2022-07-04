using StudentsInformationSystem;

var service = new Service();

Task5MoveStudent();


void CreateDepartment()
{
    Console.WriteLine("Iveskite norimo sukurti Departamento pavadinima");
    var name = Console.ReadLine();
    service.CreateDepartment(name);
    Console.WriteLine("Departamentas sukurtas");
}
void CreateLecture()
{
    Console.WriteLine("Iveskite norimos sukurti paskaitos pavadinima");
    var name = Console.ReadLine();
    service.CreateLecture(name);
    Console.WriteLine("Paskaita sukurta");
}
void CreateStudent()
{
    Console.WriteLine("Iveskite naujo studento varda");
    var name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Iveskite naujo studento pavarde");
    var lastName = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Iveskite naujo studento Katedros id");
    service.GetDepartments();
    var departmentId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.CreateStudent(name, lastName, departmentId);
    Console.WriteLine("Studentas sukurtas");  
}
void Task1CreateDepartmentWithAssignments()
{
    Console.WriteLine("Iveskite norimo sukurti Departamento pavadinima");
    var name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Iveskite paskaitos, kuria norite priskirti id");
    service.GetLectures();
    var lectId = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Iveskite studento, kuri norite priskirti id");
    service.GetStudents();
    var studentId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.CreateDepartmentWithStudentsAndLectures(name, lectId, studentId);
    Console.WriteLine("Katedra sukurta");
}
void Task2AssignLectureToDepartment()
{
    Console.WriteLine("Iveskite katedros, kuriai norite priskirti paskaita id\n");
    service.GetDepartments();
    var depId = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Iveskite paskaitos, kuria norite priskirti id\n");
    service.GetLectures();
    var lectId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.AssignLectureToDepartment(depId, lectId);
    Console.WriteLine("Paskaite prideta");

}
void Task2AsssignStudentToDepartment()
{
    Console.WriteLine("Iveskite katedros, kuriai norite priskirti studenta id\n");
    service.GetDepartments();
    var depId = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Iveskite studento, kuri norite priskirti id");
    service.GetStudents();
    var studId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.AssignStudentToDepartment(depId, studId);
    Console.WriteLine("Studentas pridetas");
}
void Task3CreateLectureAndAssignToDepartment()
{
    Console.WriteLine("Iveskite norimos sukurti paskaitos pavadinima");
    var name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Iveskite Katedros, kuria norite priskirti id");
    service.GetDepartments();
    var depId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.CreateLectureAndAssignToDepartment(name, depId);
    Console.WriteLine("Paskaita sukurta, Katedra priskirta");

}
void Task4CreateStudentAddLecturesAndDepartment()
{
    Console.WriteLine("Iveskite naujo studento varda");
    var name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Iveskite naujo studento pavarde");
    var lastName = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Iveskite naujo studento Katedros id");
    service.GetDepartments();
    var departmentId = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Iveskite paskaitos, kuria norite priskirti id");
    service.GetLectures();
    var lectId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.CreateStudentAddLecturesAndDepartment(name, lastName, departmentId, lectId);
    Console.WriteLine("Studentas sukurtas, informacija prideta");
}
void Task5MoveStudent()
{
    Console.WriteLine("Iveskite studento, kurio Katedra norite keisti id");
    service.GetStudents();
    var studId = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Iveskite Katedros, kuria norite priskirti id");
    service.GetDepartments();
    var depId = int.Parse(Console.ReadLine());
    Console.Clear();
    service.MoveStudent(studId, depId);
    Console.WriteLine("Informacija atnaujinta");

}
void Task6StudentsFromSameDepartment()
{
    Console.WriteLine("Pasirinkite, kurio departamento studentus norite matyti?");
    service.GetDepartments();
    var id = int.Parse(Console.ReadLine());
    var oneDepStudents = service.StudentsSameDepartment(id);
    foreach (var student in oneDepStudents)
    {
        Console.WriteLine($"{student.Id}, {student.Name}, {student.LastName}\n");
    }
}



