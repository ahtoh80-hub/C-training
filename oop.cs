Person person1 = new("Ваня К", 20);
Person person2 = new("Елена Г", 18);
Person person3 = new("Инна Н", 24);

Repository repository = new Repository(3);

repository.Append(person1); // 0 id
repository.Append(person2); // 1 id
repository.Append(person3); // 2 id


//Печать репозитория с помощью класса
Printer print = new Printer(); //определение класса 
print.Print(repository);


//Забрать запись по ID используя метод GetPersonById класса repository
Person result = repository.GetPersonById(2);
Console.WriteLine($"{result.Name}");

Console.WriteLine("Все прошло удачно");

