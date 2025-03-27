using Person;

//person.Name = "Alice";
//person.Age = 25;
//Console.WriteLine("Name: " + person.Name);
//Console.WriteLine("Age: " + person.Age);
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
PersonClass person = new PersonClass(name, age);
