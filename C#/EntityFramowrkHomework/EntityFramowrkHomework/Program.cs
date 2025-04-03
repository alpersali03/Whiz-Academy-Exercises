using EntityFramowrkHomework;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main()
    {
        using(AppDbContext db = new AppDbContext()){
            // // Town t1 = new Town();
            // // t1.Name = "haskovo";
            // // Town t2 = new Town();
            // // t2.Name = "st z";
            // // Town t4 = new Town();
            // // t4.Name = "varna";


            // var sofia = db.Towns.FirstOrDefault(t=>t.Name == "sofia");
            // var haskovo = db.Towns.FirstOrDefault(t => t.Name == "haskovo");
            // var varna = db.Towns.FirstOrDefault(t => t.Name == "varna");


            // var slaveykov = new Address();
            // slaveykov.AddressText = "ul. Vuzhrazhdane 20";
            // slaveykov.TownId = sofia.TownId;

            // var karshiaka = new Address();
            // karshiaka.AddressText = "ul. Hristo Botev 54";
            // karshiaka.TownId = varna.TownId;

            


            // //Town town = db.Towns.FirstOrDefault(x=>x.Name == "PloveDiv");
            // //town.Name = "";


            // //db.Towns.Remove(town);

            // db.Addresses.Add(karshiaka);    
            // db.SaveChanges();               

            //////// 
            // gettig 

            //var addresessAtSofia = db.Addresses.Include(t=>t.Town).Where(a=>a.TownId == 2).ToList();


            //var addreses = db.Addresses.Where(a => a.TownId == 4).ToList();

            //foreach (var addr in addresessAtSofia)
            //{
            //    Console.WriteLine($"{addr.AddressText}, {addr.Town.Name}");

            //}
;
            Employee employee = new Employee();
            employee.FirstName = "Alper";
            employee.LastName = "Sali";
            employee.AdressId = 1;
            employee.HireDate = "27-02-2025";
            employee.DepartmentId = 1;
            employee.Email = "alsalilee@gmail.com";
            employee.JobTitle = "Software Engineer";
            db.Employees.Add(employee);

            Employee employee2 = new Employee();
            employee2.FirstName = "Georgi";
            employee2.LastName = "Georgiev";
            employee2.AdressId = 2;
            db.Employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Denis";
            employee3.LastName = "Hasan";
            employee3.AdressId = 3;
            db.Employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Pasha";
            employee4.LastName = "Berber";
            employee4.AdressId = 4;
            db.Employees.Add(employee4);

            db.SaveChanges();


            //EmployeeProject employeeProject = new EmployeeProject();
            //employeeProject.Id = 1;
            //employeeProject.EmployeeId = 2; 
            //employeeProject.ProjectId = 2;

            //EmployeeProject employeeProject2 = new EmployeeProject();
            //employeeProject2.Id = 2;
            //employeeProject2.EmployeeId = 3;
            //employeeProject2.ProjectId = 3;

            //EmployeeProject employeeProject3 = new EmployeeProject();
            //employeeProject3.Id = 3;
            //employeeProject3.EmployeeId = 4;
            //employeeProject3.ProjectId = 4;

            //EmployeeProject employeeProject4 = new EmployeeProject();
            //employeeProject4.Id = 4;
            //employeeProject4.EmployeeId = 5;
            //employeeProject4.ProjectId = 5;

            //db.EmployeeProjects.AddRange(employeeProject1, employeeProject2, employeeProject3, employeeProject4);
            //db.SaveChanges();

            //Department department = new Department();
            //department.DepartmentId = 1;
            //department.DepartmentName = "Human Resources";
            //db.Departments.Add(department);

            //Department department2 = new Department();
            //department2.DepartmentId = 2;
            //department2.DepartmentName = "Software";
            //db.Departments.Add(department2);

            //Department department3 = new Department();
            //department3.DepartmentId = 3;
            //department3.DepartmentName = "Bankers";
            //db.Departments.Add(department3);

            //Department department4 = new Department();
            //department4.DepartmentId = 4;
            //department4.DepartmentName = "Accountancy";
            //db.Departments.Add(department4);

            //Project project = new Project();
            //project.ProjectId = 1;
            //project.Name = "TestProject";
            //project.Description = "Testing";
            //project.StartDate = "20-2-2025";
            //project.EndDate = "27-2-2025";
            //db.Add(project);

        }
    }
}