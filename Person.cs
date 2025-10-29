class Person
{
    // private string name;
    // private int age;
    //конструктор заполнения класса Person() - всегда совпадает по имени с классом (инициализация)
    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }
    public string Name { get; set; }
    public int Age { get; set; }




    // public string Name // Метод ввода/вывода информации класса во вне (Name) Обращение к имени
    // {
    //     get { return name; }
    //     set { name = value; }
    // }
    // public int Age  // Метод вывода информации класса во вне (Age)
    // {
    //     get { return age; }
    //     set { age = value; }
    //  }
}