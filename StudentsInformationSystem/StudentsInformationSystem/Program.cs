using StudentsInformationSystem;

var service = new Service();

Task8StudentsFromSameLecture();


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
void AssignLectureToStudent()
{
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine("Iveskite studento, kuriam norite priskirti paskaita id\n");
        service.GetStudents();
        var studId = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Iveskite paskaitos, kuria norite priskirti id\n");
        service.GetLectures();
        var lectId = int.Parse(Console.ReadLine());
        Console.Clear();
        service.AssignLectureToStudent(studId, lectId);
        Console.Clear();
        Console.WriteLine("Paskaita priskirta, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }
    
}
void Task1CreateDepartmentWithAssignments()
{
    bool repeat = true;
    while (repeat)
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
        Console.WriteLine("Katedra sukurta, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        Console.Clear();
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }

}
void Task2AssignLectureToDepartment()
{
    bool repeat = true;
    while (repeat)
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
        Console.WriteLine("Paskaita priskirta, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        Console.Clear();
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }

}
void Task2AsssignStudentToDepartment()
{
    bool repeat = true;
    while (repeat)
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
        Console.WriteLine("Studentas pridetas, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        Console.Clear();
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }

}
void Task3CreateLectureAndAssignToDepartment()
{
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine("Iveskite norimos sukurti paskaitos pavadinima");
        var name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Iveskite Katedros, kuria norite priskirti id");
        service.GetDepartments();
        var depId = int.Parse(Console.ReadLine());
        Console.Clear();
        service.CreateLectureAndAssignToDepartment(name, depId);
        Console.WriteLine("Paskaita sukurta, Katedra priskirta, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        Console.Clear();
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }

}
void Task4CreateStudentAddLecturesAndDepartment()
{
    bool repeat = true;
    while (repeat)
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
        Console.WriteLine("Studentas sukurtas, informacija prideta, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        Console.Clear();
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }

}
void Task5MoveStudent()
{
    bool repeat = true;
    while (repeat)
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
        Console.WriteLine("Informacija atnaujinta, jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        Console.Clear();
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }
}
void Task6StudentsFromSameDepartment()
{
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine("Pasirinkite, kurio departamento studentus norite matyti?");
        service.GetDepartments();
        var id = int.Parse(Console.ReadLine());
        var oneDepStudents = service.StudentsSameDepartment(id);
        foreach (var student in oneDepStudents)
        {
            Console.WriteLine($"{student.Id}, {student.Name}, {student.LastName}\n");
        }
        Console.Clear();
        Console.WriteLine("Jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }

}
void Task7LecturesFromSameDepartment()
{
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine("Pasirinkite, kurio departamento paskaitas norite matyti?");
        service.GetDepartments();
        var id = int.Parse(Console.ReadLine());
        Console.Clear();
        service.LecturesFromSameDepartment(id);
        Console.WriteLine("Jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }
}
void Task8StudentsFromSameLecture()
{
    bool repeat = true;
    while (repeat)
    {
        Console.WriteLine("Iveskite studento, kurio paskaitas norite perziureti id");
        service.GetStudents();
        var studId = int.Parse(Console.ReadLine());
        Console.Clear();
        service.LecturesFromSameStudent(studId);
        Console.WriteLine("Jeigu norite baigti spauskite 0, jeigu norite testi - spauskite enter");
        if (Console.ReadLine() == "0")
        {
            repeat = false;
        }
    }
}


