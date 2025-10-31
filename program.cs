Person person1 = new("Ваня К", 20);
Person person2 = new("Елена Г", 18);
Person person3 = new("Инна Н", 24);

Repository repository = new Repository(3);

//repository.Append(person1); // 0 id
//repository.Append(person2); // 1 id
//repository.Append(person3); // 2 id
repository.Append(person1, person2, person3); //C# за кулисами сам создает массив типа: Append(New Person[] {person1,person2,person3});

//Печать репозитория с помощью класса
Printer print = new Printer(); //определение класса 
print.Print(repository);


//Забрать запись по ID используя метод GetPersonById класса repository
Person result = repository.GetPersonById(2);
Console.WriteLine($"{result.Name}");
//Новый унаследованный класс Student:
Student student = new Student("Студент 1", 18, "Школа №1");
Console.WriteLine(student.StringToPrint());
//Новый унаследованный класс Employee:
Employee employee = new Employee("Сотрудник 1", 18, 25000);
Console.WriteLine(employee.StringToPrint());
//Новый унаследованный класс Employee:
Teacher teacher = new Teacher("Преподаватель 1", 45, "Математика");
Console.WriteLine(teacher.StringToPrint());

Console.WriteLine("Все прошло удачно");
//Console.ReadKey();
