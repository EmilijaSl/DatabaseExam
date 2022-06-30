using StudentsInformationSystem;

var service = new Service();

CreateStudent();


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
    service.CreateStudent(name, lastName);
    Console.WriteLine("Studentas sukurtas");  
}