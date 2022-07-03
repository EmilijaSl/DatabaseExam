using StudentsInformationSystem;

var service = new Service();

AssignLectureToDepartment();


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
void CreateStudent() //pataisyti, kad prisiskirtu dep ir pask kuriant studenta (return list dep ir return list paskaitu pasirinkimui) lista returninant foreach 
{
    Console.WriteLine("Iveskite naujo studento varda");
    var name = Console.ReadLine();
    Console.WriteLine("Iveskite naujo studento pavarde");
    var lastName = Console.ReadLine();
    Console.WriteLine($"{service.GetDepartments}\nIveskite naujo studento Katedros id");
    var departmentId = int.Parse(Console.ReadLine());
    service.CreateStudent(name, lastName, departmentId);
    Console.WriteLine("Studentas sukurtas");  
}
void StudentsFromSameDepartment6()
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
void AssignLectureToDepartment()
{
    Console.WriteLine($"Iveskite katedros, kuriai norite priskirti paskaita id\n");
    service.GetDepartments();
    var depId = int.Parse(Console.ReadLine());
    Console.WriteLine($"Iveskite paskaitos, kuria norite priskirti id\n");
    service.GetLectures();
    var lectId = int.Parse(Console.ReadLine());
    service.AssignLectureToDepartment(depId, lectId);

}