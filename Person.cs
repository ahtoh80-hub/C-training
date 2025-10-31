class Person
{
    // private string name;
    // private int age;
    //конструктор заполнения класса Person() - всегда совпадает по имени с классом (инициализация)
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string Name { get; protected set; } //protected для доступа к унаследованным классам (вместо private)
    public int Age { get; protected set; }

    //Метод формирования стринговой переменной для печати:
    public virtual string StringToPrint() //Виртуальный метод может быть переопределен в классах наследниках!!!!
    {
        return $"Имя:{this.Name}; Возраст:{this.Age};";
    }

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