using System.Net.Http.Headers;
Teacher person1 = new Teacher("Ваня К", 20, "Математика");
Student person2 = new Student("Елена Г", 18, "Школа №2");
Employee person3 = new Employee("Инна Н", 24, 150000);

//Repository repository = new Repository(10);

//repository.Append(person1); // 0 id
//repository.Append(person2); // 1 id
//repository.Append(person3); // 2 id
//repository.Append(person1, person2, person3); //C# за кулисами сам создает массив типа: Append(New Person[] {person1,person2,person3});




//Забрать запись по ID используя метод GetPersonById класса repository
//Person result = repository.GetById(2);
//Console.WriteLine($"{result.Name}");
//Новый унаследованный класс Student:
Student student = new Student("Студент 1", 18, "Школа №1");
Console.WriteLine(student.StringToPrint());
//Новый унаследованный класс Employee:
Employee employee = new Employee("Сотрудник 1", 18, 25000);
Console.WriteLine(employee.StringToPrint());
//Новый унаследованный класс Employee:
Teacher teacher = new Teacher("Преподаватель 1", 45, "Математика");
Console.WriteLine(teacher.StringToPrint());

//repository.Append(student, employee, teacher);// Добавляем в наш репозиторий

//Полиморфизм: в Person можно класть и Teacher и Student и Employee!
//Person person = new Teacher("", 0, ""); //в данном случае person - является полиморфной переменной
//person = new Student("", 0, "");

Person person = new Teacher("Елена", 20, "Математика");
//person = new NullPerson();
//repository.Append(person);// Добавляем в наш репозиторий

NewRepo newRepo = new NewRepo();
newRepo.Append(person1, person2, person3);
newRepo.Append(student, employee, teacher);
//Печать репозитория с помощью класса
for (int i = 0; i < 1000; i++)
{
    newRepo.Append(new Employee($"Working {i}", Random.Shared.Next(20, 70), Random.Shared.Next(50000, 250000)));
}

Printer print = new Printer(); //определение класса 
print.Print(newRepo);

//Teacher teacher1 = person as Teacher; //пример преобразования Person в Teacher
//Teacher teacher1 = (Teacher)person;// пример преобразования Person в Teacher

Console.WriteLine(person.Return());

//неопределенный тип данных класс User (ClassOfT):
User<int, string> user = new User<int, string>();
user.Id = 1;
user.Id2 = "1";
Console.WriteLine(user.Id);
Console.WriteLine(user.Id2);



Console.WriteLine("Все прошло удачно");
//Console.ReadKey();
